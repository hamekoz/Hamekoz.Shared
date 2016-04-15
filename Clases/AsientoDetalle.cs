using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class AsientoDetalle : IPersistible, IIdentifiable
	{
		public int Id {
			get;
			set;
		}

		public Asiento Asiento {
			get;
			set;
		}

		public CuentaContable CuentaContable {
			get;
			set;
		}

		public Cotizacion Cotizacion {
			get;
			set;
		}

		public decimal Debe {
			get;
			set;
		}

		public decimal Haber {
			get;
			set;
		}

		public CentroDeCosto CentroDeCosto {
			get;
			set;
		}

		//UNDONE aca el comprobante debe ser una clase base de todos los comprobantes
		public int ComprobanteId { get; set; }
	}
}
