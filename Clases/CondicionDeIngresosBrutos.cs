//UNDONE CondicionDeIngresosBrutos
namespace Hamekoz.Negocio
{
	public class CondicionDeIngresosBrutos
	{
		public TipoDeContribuyenteDeIngresosBrutos TipoContribuyente { 
			get; 
			set;
		}

		public JurisdiccionDeIngresosBrutos Jurisdiccion { 
			get; 
			set;
		}

		public string NumeroInscripcion { 
			get; 
			set;
		}

		public CondicionDeIngresosBrutos ()
		{
			//FIX aca no deberia inicializarse objetos
			TipoContribuyente = new TipoDeContribuyenteDeIngresosBrutos ();
			Jurisdiccion = new JurisdiccionDeIngresosBrutos ();
		}

		public override string ToString ()
		{
			return "CondicionIngresosBrutos: " + TipoContribuyente.Descripcion;
		}
	}
}
