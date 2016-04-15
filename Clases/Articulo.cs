using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Articulo : IPersistible, IIdentifiable, IDescriptible
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

		public string NombreCorto {
			get;
			set;
		}

		public decimal Precio {
			get;
			set;
		}

		public double TasaIVA {
			get;
			set;
		}

		public decimal IVA {
			get {
				return Math.Round (Precio - Precio / (1 + TasaIVA / 100), 2);
			}
		}

		public decimal ImpuestosInternos {
			get;
			set;
		}

		public decimal Neto {
			get {
				return Math.Round (Precio - IVA - ImpuestosInternos, 2);
			}
		}

		public Medidas Medida {
			get;
			set;
		}

		public Rubro Rubro {
			get;
			set;
		}

		public Estados Estado {
			get;
			set;
		}

		public Articulo ()
		{
			TasaIVA = 21;
		}

		string IDescriptible.Descripcion {
			get {
				return Nombre;
			}
		}
	}
}