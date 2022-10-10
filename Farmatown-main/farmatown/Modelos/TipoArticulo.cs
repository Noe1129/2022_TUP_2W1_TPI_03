using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class TipoArticulo
    {
        public TipoArticulo(int idTipoArticulo, string descripcion)
        {
            IdTipoArticulo = idTipoArticulo;
            Descripcion = descripcion;
        }

        public int IdTipoArticulo { get; set; }
        public string Descripcion { get; set; }
    }
}
