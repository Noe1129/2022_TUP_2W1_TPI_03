using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    class Factura
    {
		public int IdFactura { get; set; }
		public int IdUsuario { get; set; }
		public int DniCliente { get; set; }
		public DateTime Fecha { get; set; }
		public double Total { get; set; }
        public bool ObraSocial { get; set; }
        public int FormaPago { get; set; }
        public List<DetalleFactura> Detalles { get; set; }

		public Factura()
		{
			Detalles = new List<DetalleFactura>();
		}

        public Factura(int idUsuario, int dniCliente,  double total, bool obraSocial, int formaPago,List<DetalleFactura> detalles)
        {
            IdUsuario = idUsuario;
            DniCliente = dniCliente;
            Total = total;
            ObraSocial = obraSocial;
            Detalles = detalles;
			FormaPago = formaPago;
        }

        public void AgregarDetalle(DetalleFactura detalle)
		{
			Detalles.Add(detalle);
		}

		public void QuitarDetalle(int indice)
		{
			Detalles.RemoveAt(indice);
		}

		public void LimpiarDetalles()
        {

				Detalles.Clear() ;

		}

		public double CalcularTotal()
		{
			double total = 0;
			foreach (DetalleFactura detalle in Detalles)
			{
				total += detalle.CalcularSubtotal();
			}
			return total;
		}

		public double CalcularTotalDescontado()
        {
			double total = 0;
			foreach (DetalleFactura detalle in Detalles)
			{
				total += detalle.CalcularMontoDescontado();
			}
			return total;
		}

        public int TieneObraSocial()
        {
            if (ObraSocial)
            {
				return 1;
            } else
            {
				return 0;
			}
        }
    }
}
