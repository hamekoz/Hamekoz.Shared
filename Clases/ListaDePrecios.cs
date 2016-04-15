using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class ListaDePrecios : IPersistible, IIdentifiable, IDescriptible
	{
		public int Id { 
			get; 
			set; 
		}

		public string Descripcion { 
			get; 
			set; 
		}

		public double Porcentaje { 
			get; 
			set;
		}
	}
}
