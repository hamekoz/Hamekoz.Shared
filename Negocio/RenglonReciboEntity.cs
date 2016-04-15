using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
    public class RenglonReciboEntity : IItem
    {
        public long IdRecibo { get; set; }

        public int NumeroRenglon { get; set; }

        public CuentaContableEntity CuentaContable { get; set; }

        public double ImporteTotal { get; set; }

        public int IdCheque { get; set; }
        //no implementado / pasar a objeto
        public int IdRetencion { get; set; }
        //no implementado / pasar a objeto


        public RenglonReciboEntity()
        {
            //Aca no se deben iniciar objetos
            CuentaContable = new CuentaContableEntity();
        }

        #region IItem implementation

        string IItem.Descripcion
        {
            get
            {
                return CuentaContable.Cuenta;
            }
        }

        string IItem.DescripcionCorta
        {
            get
            {
                return CuentaContable.Cuenta.Substring(0, 40);
            }
        }

        double IItem.Cantidad
        {
            get
            {
                return 1;
            }
        }

        double IItem.Precio
        {
            get
            {
                return ImporteTotal;
            }
        }

        double IItem.IVA
        {
            get
            {
                return 0;
            }
        }

        double IItem.TasaIVA
        {
            get
            {
                return 21;
            }
        }

        double IItem.Impuestos
        {
            get
            {
                return 0;
            }
        }

        double IItem.Total
        {
            get
            {
                return ImporteTotal;
            }
        }

        #endregion
    }
}
