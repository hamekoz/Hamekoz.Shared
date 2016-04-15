namespace Hamekoz.Negocio
{
	interface IRemitoDetalle
	{
		long RemitoId { get; set; }

		int Renglon { get; set; }

		Articulo Articulo { get; set; }

		long LoteId { get; set; }

		double Cantidad { get; set; }

		double Precio { get; set; }

		double Total { get; }
	}
}
