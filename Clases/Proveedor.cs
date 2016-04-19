using Hamekoz.Core;
using Hamekoz.Fiscal;
using System.Collections.Generic;

namespace Hamekoz.Negocio
{
	public class Proveedor : IDescriptible, IResponsable
	{
		public int Id {
			get;
			set;
		}

		public string CUIT {
			get;
			set;
		}

		public string IIBB {
			get;
			set;
		}

		public string DNI {
			get;
			set;
		}

		public string RazonSocial {
			get;
			set;
		}

		public Domicilio Domicilio {
			get;
			set;
		}

		public CondicionDePago CondicionDePago {
			get;
			set;
		}

		public Estados Estado {
			get;
			set;
		}

		public SituacionIVA CondicionDeIVA {
			get;
			set;
		}

		IList<Telefono> Telefonos {
			get;
			set;
		}

		public string Email {
			get;
			set;
		}

		public override string ToString ()
		{
			return RazonSocial;
		}

		string IDescriptible.Descripcion {
			get {
				return RazonSocial;
			}
		}

		string IResponsable.Domicilio {
			get {
				return Domicilio.ToString ();
			}
		}
	}
}
