namespace Hamekoz.Negocio
{
    public class Stock
    {
        public string Rubro
        {
            get
            {
                return Articulo.Rubro.Descripcion;
            }
        }

        public Articulo Articulo { get; set; }

        public string Medida
        {
            get
            {
                return Articulo.Medida.ToString();
            }
        }

        public double Cantidad { get; set; }

        public override string ToString()
        {
            return string.Format("Codigo: {0}, Articulo: {1}, Rubro: {2}, Medida: {3}", Articulo.Codigo, Articulo.Descripcion, Rubro, Medida);
        }
    }
}
