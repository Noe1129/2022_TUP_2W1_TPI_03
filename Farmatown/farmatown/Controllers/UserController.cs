using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using farmatown.Modelos;
using farmatown.Vistas;

namespace farmatown.Controllers
{
    public class UserController
    {
        private SqlDataReader dr;
        public string StrConnection { get; }
        public SqlCommand Command { get; }
        public SqlConnection Conn { get; }

        public UserController()
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

        

        //METODOS DEL CONTROLADOR DE USUARIOS
        public bool VerificarUsuario(string usu,string pwr)
        {
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_VERIFICAR_LOGIN");
            Command.Parameters.AddWithValue("@usuario", usu);
            Command.Parameters.AddWithValue("@contraseña", pwr);

            //Ejecuto el proc. almacenado para verificar si existe el usuario
            dr = Command.ExecuteReader();

            if (dr.Read())//este metodo devuelve true si coinciden los datos con la DB
            {
                dr.Close();
                CloseConn();
                return true;
            }
            else
            {
                dr.Close();
                CloseConn();
                return false;
            }
        }

        public Usuario obtenerUsuario(string usu,string pwr) {
            Command.Parameters.Clear();

            SetCommand(CommandType.StoredProcedure, "SP_OBTENER_DATOS_USUARIO");
            Command.Parameters.AddWithValue("@usuario", usu);
            Command.Parameters.AddWithValue("@contraseña", pwr);

            //parametros de salida de SQL
            SqlParameter id = new SqlParameter("@idUsuario", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
            Command.Parameters.Add(id);

            SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar,20);
            nombre.Direction = ParameterDirection.Output;
            Command.Parameters.Add(nombre);

            SqlParameter apellido = new SqlParameter("@apellido",SqlDbType.NVarChar,20);
            apellido.Direction = ParameterDirection.Output;
            Command.Parameters.Add(apellido);

            SqlParameter tipoUsuario = new SqlParameter("@tipoUsuario",SqlDbType.Int);
            tipoUsuario.Direction = ParameterDirection.Output;
            Command.Parameters.Add(tipoUsuario);

            try {
                OpenConn();
                Command.ExecuteNonQuery();
                //ASIGNAMOS LOS PARAMTROS A LOS ATRIBUTOS
                int valorId = (int)id.Value;
                string valorNombre = (string)nombre.Value;
                string valorApellido = (string)apellido.Value;
                int valorTipoUsuario = (int)tipoUsuario.Value;

                //SE CREA EL USUARIO
                Usuario usuario = new Usuario(valorId, valorNombre, valorApellido, valorTipoUsuario);

                return usuario;
            }
            catch (Exception e ) {
                throw e;
            } finally {
                CloseConn();
            }          
        }

        internal DataTable obtenerTiposUsuarioComboBox()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_TIPOS_USUARIO_COMBO_BOX");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        internal DataTable ObtenerUsuariosGrilla()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_USUARIOS_GRILLA");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public void EliminarUsuario(int idUsuario)
        {
            OpenConn();
            //asegurase de mantener limpios los parametros
            Command.Parameters.Clear();
            //creo el comando 
            SetCommand(CommandType.StoredProcedure, "SP_ELIMINAR_USUARIO");
            Command.Parameters.AddWithValue("@idUsuario", idUsuario);
            Command.ExecuteNonQuery();
            CloseConn();
        }

        public void CrearUsuario(Usuario usuario)
        {
            Command.Parameters.Clear();

            SetCommand(CommandType.StoredProcedure, "SP_CREAR_USUARIO");
            Command.Parameters.AddWithValue("@nombreReal", usuario.NomUsuario);
            Command.Parameters.AddWithValue("@apellido", usuario.ApeUsuario);
            Command.Parameters.AddWithValue("@username", usuario.User);
            Command.Parameters.AddWithValue("@password", usuario.Password);
            Command.Parameters.AddWithValue("@tipoUsuario", usuario.TipoUsuario);
            OpenConn();
            Command.ExecuteNonQuery();

            CloseConn();
        }
    }
}
