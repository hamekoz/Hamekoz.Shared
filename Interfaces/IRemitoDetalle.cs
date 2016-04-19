using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public interface IRemitoDetalle
	{
		IRemito Remito { get; set; }

		int Renglon { get; set; }

		Articulo Articulo { get; set; }

		Lote Lote { get; set; }

		decimal Cantidad { get; set; }

		decimal Precio { get; set; }

		decimal Total { get; }
	}
}
