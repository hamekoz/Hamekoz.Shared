using System;

namespace Hamekoz.Negocio
{
	public class MovimientoDeArticulos
	{
		public int Id { get; set; }

		public TipoDeMovimiento TipoMovimiento { get; set; }

		public DateTime Fecha { get; set; }

		public Articulo Articulo { get; set; }

		public long IdLote { get; set; }
		//pasar a objeto
		public double Cantidad { get; set; }

		public string Comentarios { get; set; }

		public int IdDepositoOrigen { get; set; }
		//pasar a objeto
		public int IdDepositoDestino { get; set; }
		//pasar a objeto

		public MovimientoDeArticulos ()
		{
			//FIX aca no se deben inicializar objetos
			TipoMovimiento = new TipoDeMovimiento ();
			Articulo = new Articulo ();
		}
	}
}
