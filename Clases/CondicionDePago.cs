using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class CondicionDePago : IPersistible, IIdentifiable, IDescriptible
	{
		public int Id {
			get;
			set;
		}

		public string Descripcion {
			get;
			set;
		}

		public int Dias {
			get;
			set;
		}
	}
}