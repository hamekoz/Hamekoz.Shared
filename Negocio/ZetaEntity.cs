using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
    public class ZetaEntity : IZeta
    {
        public int NumeroReporte { get; set; }

        public int CantidadDFCancelados { get; set; }

        public int CantidadDNFHEmitidos { get; set; }

        public int CantidadDNFEmitidos { get; set; }

        public int CantidadDFEmitidos { get; set; }

        public int UltimoDocFiscalBC { get; set; }

        public int UltimoDocFiscalA { get; set; }

        public double MontoVentasDocFiscal { get; set; }

        public double MontoIVADocFiscal { get; set; }

        public double MontoImpInternosDocFiscal { get; set; }

        public double MontoPercepcionesDocFiscal { get; set; }

        public double MontoIVANoInscriptoDocFiscal { get; set; }

        public int UltimaNotaCreditoBC { get; set; }

        public int UltimaNotaCreditoA { get; set; }

        public double MontoVentasNotaCredito { get; set; }

        public double MontoIVANotaCredito { get; set; }

        public double MontoImpInternosNotaCredito { get; set; }

        public double MontoPercepcionesNotaCredito { get; set; }

        public double MontoIVANoInscriptoNotaCredito { get; set; }

        public int UltimoRemito { get; set; }

        public int CantidadNCCanceladas { get; set; }

        public int CantidadDFBCEmitidos { get; set; }

        public int CantidadDFAEEmitidos { get; set; }

        public int CantidadNCBCEmitidos { get; set; }

        public int CantidadNCAEmitidos { get; set; }
    }
}
