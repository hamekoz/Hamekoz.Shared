using System;

namespace Hamekoz.Negocio
{
	public class CuentaBaseEntity
	{
		public int CuentaContableId { get; set; }

		public int CodigoInicio { get; set; }

		public int CodigoFin { get; set; }

		public Boolean Eliminado { get; set; }
	}
}
