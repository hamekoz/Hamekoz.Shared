namespace Hamekoz.Negocio
{
	public class TipoDeCuentaContable
	{
		public int Id { get; set; }

		public string Descripcion { get; set; }

		public override string ToString ()
		{
			return "TipoCuentaContableEntity: " + Id + " - descripcion" + Descripcion;
		}
	}
}
