using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	//TODO Revisar si realmente esta bien como clase o puede ser un enumerado
	public class JurisdiccionDeIngresosBrutos : IPersistible, IIdentifiable, IDescriptible
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