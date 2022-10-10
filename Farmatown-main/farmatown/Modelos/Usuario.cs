using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class Usuario
    {
        public Usuario(int idUsuario, string nomUsuario, string apeUsuario, int tipoUsuario)
        {
            IdUsuario = idUsuario;
            NomUsuario = nomUsuario;
            ApeUsuario = apeUsuario;
            TipoUsuario = tipoUsuario;
        }
        public Usuario()
        {

        }

        public Usuario(string nomUsuario, string apeUsuario, string user, string password, int tipoUsuario)
        {
            NomUsuario = nomUsuario;
            ApeUsuario = apeUsuario;
            User = user;
            Password = password;
            TipoUsuario = tipoUsuario;
        }

        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string ApeUsuario { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int TipoUsuario { get; set; }

    }
}
