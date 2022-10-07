using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class Cliente
    {
        public Cliente(int dni,int telefono, string nombre, string apellido)
        {
            Dni = dni;
            Telefono = telefono;
            Nombre = nombre;
            Apellido = apellido;
        }

        public int Dni { get; set; }
        public int Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
