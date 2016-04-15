using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class CondicionDePagoEntity : IDescriptible
	{
		public int Id { get; set; }

		public string Descripcion { get; set; }

		public int Dias { get; set; }

		public override string ToString ()
		{
			return String.Format ("CondicionDePago: {0} - {1} - Dias: {2}", Id, Descripcion, Dias);
		}
	}
}