using Hamekoz.Core;

namespace Hamekoz.Negocio
{
    public class JurisdiccionIngresosBrutosEntity : IDescriptible
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return "JurisdiccionIngresosBrutos: " + Id + " - descripcion" + Descripcion;
        }
    }
}