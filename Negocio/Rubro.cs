using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Rubro : IDescriptible
	{
		public int Id { get; set; }

		public string Descripcion { get; set; }

		public override string ToString ()
		{
			return "Rubro: " + Descripcion;
		}
	}
}
