using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    class DetalleLote
    {
        public Articulo Articulo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CantidadComprada { get; set; }

    }
}
