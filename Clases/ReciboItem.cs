using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class ReciboItem : IPersistible, IItem
	{
		public Recibo Recibo {
			get;
			set;
		}

		public int Renglon {
			get;
			set;
		}

		public CuentaContable CuentaContable {
			get;
			set;
		}

		public decimal ImporteTotal {
			get;
			set;
		}

		//FIX el cheque no deberia ser un atributo del detalle del recibo.
		public Cheque Cheque {
			get;
			set;
		}
		//UNDONE no implementado / pasar a objeto
		public int IdRetencion {
			get;
			set;
		}

		#region IItem implementation

		string IItem.Descripcion {
			get {
				return CuentaContable.Cuenta;
			}
		}

		string IItem.DescripcionCorta {
			get {
				return CuentaContable.Cuenta.Substring (0, 40);
			}
		}

		decimal IItem.Cantidad {
			get {
				return 1;
			}
		}

		decimal IItem.Precio {
			get {
				return ImporteTotal;
			}
		}

		decimal IItem.IVA {
			get {
				return 0;
			}
		}

		decimal IItem.TasaIVA {
			get {
				return 21;
			}
		}

		decimal IItem.Impuestos {
			get {
				return 0;
			}
		}

		decimal IItem.Total {
			get {
				return ImporteTotal;
			}
		}

		#endregion
	}
}
