using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Moneda : IPersistible, IIdentifiable
	{
		public int Id {
			get;
			set;
		}

		public string Nombre {
			get;
			set;
		}

		public string Codigo {
			get;
			set;
		}

		public string Simbolo {
			get;
			set;
		}
	}
}