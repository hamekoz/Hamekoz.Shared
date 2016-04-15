using Hamekoz.Core;

namespace Hamekoz.Negocio
{
    public class ListaDePreciosEntity : IDescriptible
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public double Porcentaje { get; set; }
    }
}
