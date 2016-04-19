using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	//FIX revisar el sentido de esta clase
	public class TipoDeCuentaContable : IPersistible, IIdentifiable, IDescriptible
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
