using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    class DetalleFactura
    {
		public Articulo Articulo { get; set; }
		public int Cantidad { get; set; }
        public int Descuento { get; set; }

        public DetalleFactura(Articulo articulo, int cantidad, int descuento)
		{
			Articulo = articulo;
			Cantidad = cantidad;
			Descuento = descuento;
		}

		public double CalcularMontoDescontado()
        {
			if (Descuento > 0)
			{
				return ((Articulo.preUnitario * Cantidad) * Descuento) / 100;
			} else
            {
				return 0;
			}

		}

		public double CalcularSubtotal()
		{
			return (Articulo.preUnitario * Cantidad) - CalcularMontoDescontado();
		}

	}
}
