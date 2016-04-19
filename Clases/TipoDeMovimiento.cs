using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class TipoDeMovimiento : IPersistible, IIdentifiable, IDescriptible
	{
		public int Id {
			get;
			set;
		}

		public string Descripcion {
			get;
			set;
		}

		//FIX revisar el sentido del codigo del tipo de movimiento.
		public int Codigo {
			get;
			set;
		}

		public int Signo {
			get;
			set;
		}
	}
}
