using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class JurisdiccionDeIngresosBrutos : IDescriptible
	{
		public int Id { get; set; }

		public string Descripcion { get; set; }

		public override string ToString ()
		{
			return "JurisdiccionIngresosBrutos: " + Id + " - descripcion" + Descripcion;
		}
	}
}