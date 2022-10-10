using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    class Lote
    {
        public int IdLote { get; set; }
        public DateTime FechaCompra { get; set; }
        public List<DetalleLote> Detalles { get; set; }
    }
}
