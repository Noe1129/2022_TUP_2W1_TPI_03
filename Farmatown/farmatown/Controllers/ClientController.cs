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
    class ClientController
    {
        public string StrConnection { get; }
        public SqlCommand Command { get; }
        public SqlConnection Conn { get; }

        public ClientController()
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

        //--------------------------------------METODOS-----------------------------------

        public DataTable ObtenerClientesGrilla()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }
        public DataTable ObtenerClientesGrillaConTarjeta()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES_CON_TARJETA");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }
        public void CrearTarjeta(Tarjeta tarjeta)
        {
            try
            {
                OpenConn();
                //asegurase de mantener limpios los parametros
                Command.Parameters.Clear();
                //creo el comando y le asigno la transaccion 
                SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_TARJETA");
                Command.Parameters.AddWithValue("@nro_tarjeta", tarjeta.NroTarjeta);
                Command.Parameters.AddWithValue("@cod_seguridad", tarjeta.CodigoSeguridad);
                Command.Parameters.AddWithValue("@fecha_venc", tarjeta.FechaVenc);
                Command.Parameters.AddWithValue("@dni", tarjeta.DniCliente);

                Command.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
            
            }
            finally
            {
                CloseConn();
            }

        }
        public DataTable ObtenerClientesPorDni(int dni)
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();
            Command.Parameters.AddWithValue("@DNI", dni);
            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES_POR_DNI");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public void CrearCliente(Cliente cliente)
        {
            try
            {
                OpenConn();
                //asegurase de mantener limpios los parametros
                Command.Parameters.Clear();
                //creo el comando y le asigno la transaccion 
                SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_CLIENTE");
                Command.Parameters.AddWithValue("@DNI", cliente.Dni);
                Command.Parameters.AddWithValue("@nom_cliente", cliente.Nombre);
                Command.Parameters.AddWithValue("@ape_cliente", cliente.Apellido);
                Command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                
                Command.ExecuteNonQuery();
            }
            catch (Exception )
            {
                 
            }
            finally
            {
                CloseConn();
            }
        }

        public void ModificarCliente(Cliente cliente)
        {
            try
            {
                OpenConn();
                //asegurase de mantener limpios los parametros
                Command.Parameters.Clear();
                //creo el comando y le asigno la transaccion 
                SetCommand(CommandType.StoredProcedure, "SP_MODIFICAR_CLIENTE");
                Command.Parameters.AddWithValue("@DNI", cliente.Dni);
                Command.Parameters.AddWithValue("@nombreCliente", cliente.Nombre);
                Command.Parameters.AddWithValue("@apellidoCliente", cliente.Apellido);
                Command.Parameters.AddWithValue("@telefono", cliente.Telefono);

                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConn();
            }
        }
    }
}
