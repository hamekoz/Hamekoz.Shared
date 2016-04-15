namespace Hamekoz.Negocio
{
	public class CondicionIngresosBrutosEntity
	{
		public TipoContribuyenteIngresosBrutosEntity TipoContribuyente { get; set; }

		public JurisdiccionIngresosBrutosEntity Jurisdiccion { get; set; }

		public string NumeroInscripcion { get; set; }

		public CondicionIngresosBrutosEntity ()
		{
			//FIX aca no deberia inicializarse objetos
			TipoContribuyente = new TipoContribuyenteIngresosBrutosEntity ();
			Jurisdiccion = new JurisdiccionIngresosBrutosEntity ();
		}

		public override string ToString ()
		{
			return "CondicionIngresosBrutos: " + TipoContribuyente.Descripcion;
		}
	}
}
