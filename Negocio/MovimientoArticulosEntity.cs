using System;

namespace Hamekoz.Negocio
{
    public class MovimientoArticulosEntity
    {
        public int Id { get; set; }

        public TipoMovimientoEntity TipoMovimiento { get; set; }

        public DateTime Fecha { get; set; }

        public ArticuloEntity Articulo { get; set; }

        public long IdLote { get; set; }
        //pasar a objeto
        public double Cantidad { get; set; }

        public string Comentarios { get; set; }

        public int IdDepositoOrigen { get; set; }
        //pasar a objeto
        public int IdDepositoDestino { get; set; }
        //pasar a objeto

        public MovimientoArticulosEntity()
        {
            //FIX aca no se deben inicializar objetos
            TipoMovimiento = new TipoMovimientoEntity();
            Articulo = new ArticuloEntity();
        }
    }
}
