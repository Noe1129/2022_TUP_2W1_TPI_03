using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using farmatown.Modelos;

namespace farmatown.Controllers
{
    class FacturaController
    {
        public string StrConnection { get; }
        public SqlCommand Command { get; }
        public SqlConnection Conn { get; }

        public FacturaController()
        {
            StrConnection = Properties.Resources.strConnection;
            Conn = new SqlConnection(StrConnection);
            Command = new SqlCommand();
        }

        //METODOS GENERICOS ABRIR CONEXION SI ESTA CERRADA, CERRAR CONEXION SI ESTA ABIERTA, SETEAR COMANDO
        public void OpenConn()
        {
            if (Conn.State.Equals(ConnectionState.Closed))
                Conn.Open();
        }

        public void CloseConn()
        {
            if (Conn.State.Equals(ConnectionState.Open))
                Conn.Close();
        }

        public void SetCommand(CommandType type, string CommandText)
        {
            Command.Connection = Conn;
            Command.CommandType = type;
            Command.CommandText = CommandText;
        }



        //---------------------------------METODOS-----------------

        internal DataTable FacturaPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            
            OpenConn();
            Command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            Command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_FACTURA_POR_FECHA");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public DataTable obtenerFacturas()
        {
            Command.Parameters.Clear();
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_FACTURAS");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public DataTable obtenerDetallesPorIdFactura(int idFactura)
        {
            Command.Parameters.Clear();
            DataTable table = new DataTable();
            Command.Parameters.AddWithValue("@idFactura", idFactura);
            OpenConn();

            
            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_DETALLES_POR_ID_FACTURA");
            table.Load(Command.ExecuteReader());
            CloseConn();
            return  table;
        }


        public int ObtenerProximaFactura()
        {
            Command.Parameters.Clear();

            OpenConn();
            SetCommand(CommandType.StoredProcedure, "SP_PROXIMA_FACTURA");

            //parametros de salida de SQL
            SqlParameter next = new SqlParameter("@next", SqlDbType.Int);
            next.Direction = ParameterDirection.Output;
            Command.Parameters.Add(next);

            Command.ExecuteNonQuery();
            CloseConn();
            return (int)next.Value;
        }


        public bool ConfirmarFactura(Factura myFactura)
        {
            SqlTransaction transact = null;
            bool flag = false;
            try
            {
                OpenConn();
                transact = Conn.BeginTransaction();

                //asegurase de mantener limpios los parametros
                Command.Parameters.Clear();
                //creo el comando y le asigno la transaccion 
                SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_MAESTRO_FACTURA");
                Command.Transaction = transact;

                Command.Parameters.AddWithValue("@total", myFactura.Total);
                Command.Parameters.AddWithValue("@tieneObraSocial", myFactura.TieneObraSocial());
                Command.Parameters.AddWithValue("@dniCliente", myFactura.DniCliente);
                Command.Parameters.AddWithValue("@idUsuario", myFactura.IdUsuario);
                Command.Parameters.AddWithValue("@tipoPago", myFactura.FormaPago);

                //recibiendo el parametro de salida ID DE LA FACTURA
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@idFactura";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                //AGREGO EL PARAMETRO
                Command.Parameters.Add(param);

                Command.ExecuteNonQuery();

                int idFactura = (int)param.Value;

                myFactura.IdFactura = idFactura;

                //------ insertar detalles -------

                foreach (DetalleFactura det in myFactura.Detalles)
                {
                    Command.Parameters.Clear();
                    SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_DETALLE_FACTURA");
                    Command.Transaction = transact;

                    Command.Parameters.AddWithValue("@idFactura", myFactura.IdFactura);
                    Command.Parameters.AddWithValue("@idArticulo", det.Articulo.idArticulo);
                    Command.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    Command.Parameters.AddWithValue("@descuento", det.Descuento);
                    Command.Parameters.AddWithValue("@montoDescontado", det.CalcularMontoDescontado());
                    Command.Parameters.AddWithValue("@subtotal", det.CalcularSubtotal());
                    Command.Parameters.AddWithValue("@precio", det.Articulo.preUnitario);
                    

                    Command.ExecuteNonQuery();
                    
                }
                transact.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConn();
            }
            return flag;
        }

        public void EliminarFactura(int nroFactura)
        {
            Command.Parameters.Clear();
            OpenConn();
            SetCommand(CommandType.StoredProcedure, "SP_ELIMINAR_FACTURA");
            Command.Parameters.AddWithValue("@idFactura", nroFactura);

            Command.ExecuteNonQuery();
        }

        public void EliminarDetalle(int idDetalle)
        {
            Command.Parameters.Clear();
            OpenConn();
            SetCommand(CommandType.StoredProcedure, "SP_ELIMINAR_DETALLE");
            Command.Parameters.AddWithValue("@idDetalle", idDetalle);

            Command.ExecuteNonQuery();
        }

    }
}
