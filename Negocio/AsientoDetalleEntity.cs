namespace Hamekoz.Negocio
{
	public class AsientoDetalleEntity
	{
		public int IdAsientoDetalle { get; set; }

		public int IdAsiento { get; set; }

		public int IdCuentaContable { get; set; }

		public int IdCentroDeCosto { get; set; }

		public double Debe { get; set; }

		public double Haber { get; set; }

		public double DebePesos { get; set; }

		public double HaberPesos { get; set; }

		public int IdComprobante { get; set; }

		//RELACIONES
		public CuentaContableEntity CuentaContable { get; set; }

		public CentroDeCostoEntity CentroDeCosto { get; set; }

		public AsientoDetalleEntity ()
		{
			CuentaContable = new CuentaContableEntity ();
			CentroDeCosto = new CentroDeCostoEntity ();
		}

		public override string ToString ()
		{
			return "AsientoDetalleEntity: " + this.IdAsientoDetalle + " - Detalle ";
		}
	}
}
