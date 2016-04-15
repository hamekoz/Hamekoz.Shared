using System;
using System.Collections.Generic;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Asiento : IPersistible, IIdentifiable
	{
		public int Id {
			get;
			set;
		}

		public string Detalle {
			get;
			set;
		}

		public DateTime Fecha {
			get;
			set;
		}

		public string Comprobante {
			get;
			set;
		}

		public DateTime FechaComprobante {
			get;
			set;
		}

		public Moneda Moneda {
			get;
			set;
		}

		//UNDONE ver si tiene sentido tener aca la empresa
		public Empresa Empresa {
			get;
			set;
		}

		public bool Eliminado { get; set; }

		public List<AsientoDetalle> Renglones { get; set; }

		public Asiento ()
		{
			Renglones = new List<AsientoDetalle> ();
		}

		public override string ToString ()
		{
			return "AsientoEntity: " + Id + " - " + Detalle + " - Comprobante: " + Comprobante;
		}

	}
}