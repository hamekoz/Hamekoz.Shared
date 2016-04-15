using Hamekoz.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hamekoz.Negocio
{
    public class RemitoProveedorEntity : IComprobante
    {
        public long Id { get; set; }

        public ProveedorEntity Proveedor { get; set; }

        public string Numero { get; set; }

        public TipoComprobanteEntity TipoComprobante { get; set; }

        public DateTime FechaDeEmision { get; set; }

        public int IdFlete { get; set; }
        //pasar a objeto (todavia no se usa)
        public int IdPedido { get; set; }
        //pasar a objeto (todavia no se usa)
        public int CantidadBultos { get; set; }

        public double ValorAsegurado { get; set; }

        public string DomicilioDeEntrega { get; set; }
        //pasar a objeto DomicilioDeEntrega
        public string Observaciones { get; set; }

        public List<RenglonRemitoProveedorEntity> Renglones { get; set; }


        public RemitoProveedorEntity()
        {
            //FIX aca no se deben iniciar objetos
            Proveedor = new ProveedorEntity();
            TipoComprobante = new TipoComprobanteEntity();
            Renglones = new List<RenglonRemitoProveedorEntity>();
        }

        #region IComprobante

        IResponsable IComprobante.Responsable
        {
            get
            {
                return Proveedor;
            }
        }

        string IComprobante.PuntoDeVenta
        {
            get
            {
                return TipoComprobante.Pre;
            }
        }

        IList<IItem> IComprobante.Items
        {
            get
            {
                return Renglones.Cast<IItem>().ToList();
            }
        }

        double IComprobante.Total
        {
            get
            {
                return Renglones.Sum(r => r.PrecioTotal);
            }
        }

        double IComprobante.SubTotal
        {
            get
            {
                return Renglones.Sum(r => r.Neto);
            }
        }

        double IComprobante.IVA
        {
            get
            {
                return Renglones.Sum(r => r.IVA);
            }
        }

        double IComprobante.NOGravado
        {
            get
            {
                return Renglones.Sum(r => r.TotalImpuestos);
            }
        }

        double IComprobante.Percepciones
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
