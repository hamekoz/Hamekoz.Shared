using System;

namespace Hamekoz.Negocio
{
	public class CobranzaEntity
	{
		public int Id { get; set; }

		public long IdComprobante { get; set; }

		public long IdRecibo { get; set; }

		public double MontoImputado { get; set; }

		public DateTime Fecha { get; set; }

		public Boolean Eliminado { get; set; }
	}
}
