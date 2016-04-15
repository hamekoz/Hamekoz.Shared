namespace Hamekoz.Negocio
{
    interface IRenglonRemito
    {
        Articulo Articulo { get; set; }

        double Cantidad { get; set; }

        double Costo { get; set; }

        long IdLote { get; set; }

        long IdRemito { get; set; }

        int NumeroRenglon { get; set; }

        double PrecioTotal { get; }

        double PrecioUnitario { get; set; }
    }
}
