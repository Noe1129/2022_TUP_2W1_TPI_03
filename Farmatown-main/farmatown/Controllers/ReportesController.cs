using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Controllers
{
    public class ReportesController
    {
        public string StrConnection { get; }
        public SqlCommand Command { get; }
        public SqlConnection Conn { get; }
        public ReportesController()
        {
            StrConnection = Properties.Resources.strConnection;
            Conn = new SqlConnection(StrConnection);
            Command = new SqlCommand();
        }
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

        //articulo vendidiop
        public DataTable obtenerReporte1(int mes)
        {
            DataTable tabla = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "sp_articulosVendidos");
            Command.Parameters.AddWithValue("@mes", mes);
            tabla.Load(Command.ExecuteReader());
            CloseConn();

            return tabla;
        }

        public DataTable obtenerReporte2()
        {
            DataTable tabla = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "sp_clientesFrecuentes");
            tabla.Load(Command.ExecuteReader());
            CloseConn();

            return tabla;
        }

    }
}
