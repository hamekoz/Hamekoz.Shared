using System;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
    public class RenglonRemitoClienteEntity : IRenglonRemito, IItem
    {
        //UNDONE Los valores deben calcularse solo si no esta grabado el remito, en caso contrario son lectura directa
        double porcentaje;

        public void SetPorcentaje(double porcentaje)
        {
            this.porcentaje = porcentaje;
        }

        public long IdRemito { get; set; }

        public int NumeroRenglon { get; set; }

        public ArticuloEntity Articulo { get; set; }

        public double Cantidad { get; set; }

        public double PrecioUnitario { get; set; }

        public double PrecioTotal
        {
            get
            {
                return Math.Round(PrecioUnitario * Cantidad, 2);
            }
        }

        public double Neto
        {
            get
            {
                return Math.Round(Articulo.PrecioNeto * Cantidad * (1 + porcentaje / 100), 2);
            }
        }

        public double TotalImpuestos
        {
            get
            {
                return Math.Round(Articulo.ImpuestosInternos * Cantidad * (1 + porcentaje / 100), 2);
            }
        }

        public double IVA
        {
            get
            {
                return Math.Round(Articulo.IVA * Cantidad * (1 + porcentaje / 100), 2);
            }
        }

        public double TasaIVA
        {
            get
            {
                return Articulo.TasaIVA;
            }
        }

        public long IdLote { get; set; }
        //TODO: Pasar a objeto
        public double Costo { get; set; }

        public RenglonRemitoClienteEntity()
        {
            //HACK no se deberia inicializar aca la propiedad Articulo
            Articulo = new ArticuloEntity();
            Cantidad = 1;
        }

        #region IItem

        string IItem.Descripcion
        {
            get
            {
                return Articulo.Descripcion;
            }
        }

        string IItem.DescripcionCorta
        {
            get
            {
                return Articulo.DescripcionCorta;
            }
        }

        double IItem.Precio
        {
            get
            {
                return PrecioUnitario;
            }
        }

        double IItem.Impuestos
        {
            get
            {
                return TotalImpuestos;
            }
        }

        double IItem.Total
        {
            get
            {
                return PrecioTotal;
            }
        }

        #endregion
    }
}
