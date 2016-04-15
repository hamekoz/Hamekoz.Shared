namespace Hamekoz.Negocio
{
    public class MonedaEntity
    {
        public int IdMoneda { get; set; }

        public string Descripcion { get; set; }

        public double Cotizacion { get; set; }

        public double CotizacionPesos { get; set; }

        public override string ToString()
        {
            return "MonedaEntity: " + IdMoneda + " - Descripcion: " + Descripcion;
        }
    }
}