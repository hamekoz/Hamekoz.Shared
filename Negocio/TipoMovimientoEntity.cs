using Hamekoz.Core;

namespace Hamekoz.Negocio
{
    public class TipoMovimientoEntity : IDescriptible
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int Codigo { get; set; }

        public int Signo { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
