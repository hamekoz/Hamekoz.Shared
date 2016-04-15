using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Deposito : IPersistible, IIdentifiable, IDescriptible
	{
		public enum Tipos
		{
			Almacenaje,
			Productivo,
			Expeditivo,
		}

		public int Id {
			get; 
			set;
		}

		public string Descripcion { 
			get; 
			set; 
		}

		public Tipos Tipo {
			get;
			set;
		}
	}
}
