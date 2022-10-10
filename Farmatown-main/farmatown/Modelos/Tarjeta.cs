using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class Tarjeta
    {
        public long NroTarjeta { get; set; }
        public int CodigoSeguridad { get; set; }
        public DateTime FechaVenc { get; set; }
        public int DniCliente { get; set; }

        public Tarjeta(long nroTarjeta, int codigoSeguridad, DateTime fechaVenc, int dniCliente)
        {
            NroTarjeta = nroTarjeta;
            CodigoSeguridad = codigoSeguridad;
            FechaVenc = fechaVenc;
            DniCliente = dniCliente;
        }
    }
}
