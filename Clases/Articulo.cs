using System;
using System.Collections.Generic;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Articulo : IDescriptible
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

		public double Precio { get; set; }

		public double TasaIVA { get; set; }

		public double IVA {
			get { return Math.Round (Precio - Precio / (1 + TasaIVA / 100), 2); }
		}

		public double ImpuestosInternos { get; set; }

		public double Neto {
			get { return Math.Round (Precio - IVA - ImpuestosInternos, 2); }
		}

		public Medidas Medida { get; set; }

		public Rubro Rubro { get; set; }

		public double PuntoDePedido { get; set; }

		public double UxB { get; set; }

		public Estados Estado { get; set; }

		public Articulo ()
		{
			//FIX aca nunca deberia inicializarse los objectos asociados con instancias nuevas
			Estado = Estados.Gestion;
			Rubro = new Rubro ();
			Medida = Medidas.Unidad;
			UxB = 1;
			TasaIVA = 21;
		}

		public override string ToString ()
		{
			return Descripcion;
		}
	}
}