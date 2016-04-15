using Hamekoz.Fiscal;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Hamekoz.Negocio
{
    public class ReciboEntity : IComprobante
    {
        public long Id { get; set; }

        public AsientoEntity Asiento { get; set; }

        public ClienteEntity Cliente { get; set; }

        public string Numero { get; set; }

        public TipoComprobanteEntity TipoComprobante { get; set; }

        public DateTime FechaDeEmision { get; set; }

        double total;

        public double Total
        {
            get { return Math.Round(total, 2); }
            set { total = value; }
        }

        double subTotal;

        public double SubTotal
        {
            get { return Math.Round(subTotal, 2); }
            set { subTotal = value; }
        }

        double ivaInscripto;

        public double IVA
        {
            get { return Math.Round(ivaInscripto, 2); }
            set { ivaInscripto = value; }
        }

        public double NOGravado { get; set; }

        public double ImporteRestante { get; set; }

        public List<RenglonReciboEntity> Renglones { get; set; }

        public string CAE { get; set; }

        public string VencimientoCAE { get; set; }

        public string NumeroComprobanteAFIP { get; set; }

        public string ComentariosAFIP { get; set; }

        public Boolean Eliminado { get; set; }

        public ReciboEntity()
        {
            //FIX aca no se deben iniciar los objetos
            Cliente = new ClienteEntity();
            TipoComprobante = new TipoComprobanteEntity();
            Renglones = new List<RenglonReciboEntity>();
            Asiento = new AsientoEntity();
        }

        #region IComprobante

        IResponsable IComprobante.Responsable
        {
            get
            {
                return Cliente;
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

        double IComprobante.Percepciones
        {
            get
            {
                return 0;
            }
        }

        string IComprobante.Observaciones
        {
            get
            {
                return string.Empty;
            }
        }

        #endregion
    }
}
