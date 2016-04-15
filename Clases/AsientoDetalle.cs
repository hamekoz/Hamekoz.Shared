namespace Hamekoz.Negocio
{
	public class AsientoDetalle
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
		public CuentaContable CuentaContable { get; set; }

		public CentroDeCosto CentroDeCosto { get; set; }

		public AsientoDetalle ()
		{
			CuentaContable = new CuentaContable ();
			CentroDeCosto = new CentroDeCosto ();
		}

		public override string ToString ()
		{
			return "AsientoDetalleEntity: " + this.IdAsientoDetalle + " - Detalle ";
		}
	}
}
