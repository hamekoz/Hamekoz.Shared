using System;
using System.Collections.Generic;

namespace Hamekoz.Negocio
{
	public class AsientoEntity
	{
		public int IdAsiento { get; set; }

		public string Detalle { get; set; }

		public DateTime Fecha { get; set; }

		public DateTime FechaComprobante { get; set; }

		public string Comprobante { get; set; }

		public int IdMoneda { get; set; }

		public Boolean Eliminado { get; set; }

		public int IdEmpresa { get; set; }

		public List<AsientoDetalleEntity> RenglonesAsiento { get; set; }

		// RELACIONES
		public MonedaEntity Moneda { get; set; }

		public EmpresaEntity Empresa { get; set; }

		public AsientoEntity ()
		{
			RenglonesAsiento = new List<AsientoDetalleEntity> ();
		}

		public override string ToString ()
		{
			return "AsientoEntity: " + IdAsiento + " - " + Detalle + " - Comprobante: " + Comprobante;
		}

	}
}