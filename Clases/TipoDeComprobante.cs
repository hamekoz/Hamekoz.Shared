using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	//UNDONE refactorizar para separar el tipo del comprobante de los puntos de venta
	public class TipoDeComprobante : IPersistible, IIdentifiable, IDescriptible
	{
		public int Id {
			get;
			set;
		}

		public string Descripcion {
			get;
			set;
		}

		public string Abreviatura {
			get;
			set;
		}

		public string Letra {
			get;
			set;
		}

		public int UltimoNumero {
			get;
			set;
		}

		public string Pre {
			get;
			set;
		}

		//UNDONE reivar si tiene sentido almacenar la sucursal en el tipo de comprobante
		public Sucursal Sucursal {
			get;
			set;
		}

		public int IdEmpresa {
			get;
			set;
		}

		public TiposDeControladorFiscal Tipo {
			get;
			set;
		}

		//FIX esto deberia ser una funcion en lugar de una propiedad
		public string UltimoNumeroConFormato {
			get {
				if (Pre != null)
					return Pre.PadLeft (4, '0') + "-" + UltimoNumero.ToString ().PadLeft (8, '0');
				else
					return "";
			}
		}
	}
}
