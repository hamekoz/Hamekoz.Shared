using Hamekoz.Negocio;

namespace Hamekoz.Negocio
{
	public class RemitoProveedorDetalle : IRemitoDetalle
	{
		public long IdRemito { get; set; }

		public int NumeroRenglon { get; set; }

		public Articulo Articulo { get; set; }

		public double Cantidad { get; set; }

		public double PrecioUnitario { get; set; }

		public double PrecioTotal {
			get {
				return PrecioUnitario * Cantidad;
			}
		}

		public double Neto {
			get {
				return PrecioTotal - (Articulo.ImpuestosInternos * Cantidad) - IVA;
			}
		}

		public double TotalImpuestos {
			get {
				return Articulo.ImpuestosInternos * Cantidad;
			}
		}

		public double IVA {
			get {
				return Articulo.Precio - Articulo.Neto;
			}
		}

		public long IdLote { get; set; }
		//TODO: Pasar a objeto
		public double Costo { get; set; }

		public RemitoProveedorDetalle ()
		{
			Articulo = new Articulo ();
			Cantidad = 1;
		}
	}
}
