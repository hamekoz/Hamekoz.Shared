using Hamekoz.Core;
using Hamekoz.Negocio;

namespace Hamekoz.Negocio
{
	public class RemitoProveedorDetalle : IPersistible, IRemitoDetalle
	{
		public IRemito Remito {
			get;
			set;
		}

		public int Renglon {
			get;
			set;
		}

		public Articulo Articulo {
			get;
			set;
		}

		public decimal Cantidad {
			get;
			set;
		}

		public decimal Precio {
			get;
			set;
		}

		public decimal Total {
			get {
				return Precio * Cantidad;
			}
		}

		public decimal Neto {
			get {
				return Total - (Articulo.ImpuestosInternos * Cantidad) - IVA;
			}
		}

		public decimal TotalImpuestos {
			get {
				return Articulo.ImpuestosInternos * Cantidad;
			}
		}

		public decimal IVA {
			get {
				return Articulo.Precio - Articulo.Neto;
			}
		}

		public Lote Lote {
			get;
			set;
		}

		public decimal Costo {
			get;
			set;
		}
	}
}
