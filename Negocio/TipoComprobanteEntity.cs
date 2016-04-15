using Hamekoz.Core;

namespace Hamekoz.Negocio
{
    public class TipoComprobanteEntity : IDescriptible
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string Abreviatura { get; set; }

        public string LetraComprobante { get; set; }

        public int UltimoNumero { get; set; }

        public string Pre { get; set; }

        public int IdSucursal { get; set; }
        //pasar a objeto
        public int IdEmpresa { get; set; }
        //para definir comprobantes por empresa - todavia no se usa - pasar a objeto
        public int IdTipoFiscal { get; set; }
        //pasar a objeto
        public string UltimoNumeroConFormato
        {
            get
            {
                if (Pre != null)
                    return Pre.PadLeft(4, '0') + "-" + UltimoNumero.ToString().PadLeft(8, '0');
                else
                    return "";
            }
        }
    }
}
