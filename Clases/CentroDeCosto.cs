using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class CentroDeCosto : IPersistible, IIdentifiable, IDescriptible
	{
		public int Id {
			get;
			set;
		}

		public string Descripcion {
			get;
			set;
		}
	}
}
