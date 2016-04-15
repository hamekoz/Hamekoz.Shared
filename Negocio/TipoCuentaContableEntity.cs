namespace Hamekoz.Negocio
{
    public class TipoCuentaContableEntity
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return "TipoCuentaContableEntity: " + Id + " - descripcion" + Descripcion;
        }
    }
}
