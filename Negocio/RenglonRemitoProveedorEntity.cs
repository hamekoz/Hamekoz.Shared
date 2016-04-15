using Hamekoz.Negocio;

namespace Hamekoz.Negocio
{
	public class RenglonRemitoProveedorEntity : IRenglonRemito
	{
		public long IdRemito { get; set; }

		public int NumeroRenglon { get; set; }

		public ArticuloEntity Articulo { get; set; }

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
				return Articulo.PrecioVentaPublico - Articulo.PrecioNeto;
			}
		}

		public long IdLote { get; set; }
		//TODO: Pasar a objeto
		public double Costo { get; set; }

		public RenglonRemitoProveedorEntity ()
		{
			Articulo = new ArticuloEntity ();
			Cantidad = 1;
		}
	}
}
