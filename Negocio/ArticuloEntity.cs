using System;
using System.Collections.Generic;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class ArticuloEntity : IDescriptible
	{
		public enum Estados
		{
			Activo = 1,
			Baja = 2,
			Gestion = 3,
		}

		public int Id { get; set; }

		public string Codigo { get; set; }

		public string Descripcion { get; set; }

		public string DescripcionCorta { get; set; }

		public double PrecioVentaPublico { get; set; }

		public double TasaIVA { get; set; }

		public double IVA {
			get { return Math.Round (PrecioVentaPublico - PrecioVentaPublico / (1 + TasaIVA / 100), 2); }
		}

		public double ImpuestosInternos { get; set; }

		public double PrecioNeto {
			get { return Math.Round (PrecioVentaPublico - IVA - ImpuestosInternos, 2); }
		}

		public Medidas UxM { get; set; }

		public RubroEntity Rubro { get; set; }

		public double PuntoDePedido { get; set; }

		public double Uxb { get; set; }

		public Estados Estado { get; set; }


		public ArticuloEntity ()
		{
			//FIX aca nunca deberia inicializarse los objectos asociados con instancias nuevas
			Estado = Estados.Gestion;
			Rubro = new RubroEntity ();
			UxM = Medidas.Unidad;
			Uxb = 1;
			TasaIVA = 21;
		}

		public override string ToString ()
		{
			return Descripcion;
		}
	}
}