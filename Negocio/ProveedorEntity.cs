using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
    public class ProveedorEntity : IDescriptible, IResponsable
    {
        public enum Estado
        {
            Activo = 1,
            Gestion = 2,
            Baja = 3,
        }

        public int Id { get; set; }

        public string CUIT { get; set; }

        public string IIBB { get; set; }

        public string DNI { get; set; }

        public string RazonSocial { get; set; }

        public string Domicilio { get; set; }

        public string Localidad { get; set; }

        public string CP { get; set; }

        public CondicionDePagoEntity CondicionDePago { get; set; }

        public Estado EstadoProveedor { get; set; }

        public SituacionIVA CondicionDeIVA { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Telefono3 { get; set; }

        public string Email { get; set; }

        public ProveedorEntity()
        {
            CUIT = string.Empty;
            RazonSocial = string.Empty;
            CondicionDeIVA = SituacionIVA.CONSUMIDOR_FINAL;
            //FIX aca no se debe iniciar el objeto
            CondicionDePago = new CondicionDePagoEntity();
            EstadoProveedor = Estado.Gestion;
        }

        public override string ToString()
        {
            return RazonSocial;
        }

        public string Descripcion
        {
            get
            {
                return RazonSocial;
            }
        }
    }
}
