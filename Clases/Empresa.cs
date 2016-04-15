using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Empresa : IPersistible, IIdentifiable
	{
		public int Id { 
			get; 
			set; 
		}

		public string RazonSocial { 
			get; 
			set; 
		}

		public string CUIT { 
			get; 
			set; 
		}

		public bool AgenteDeRecaudacionARBA { 
			get; 
			set; 
		}
	}
}