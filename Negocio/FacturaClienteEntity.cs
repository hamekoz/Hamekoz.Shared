using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class FacturaClienteEntity : IComprobante
	{
		public long Id { get; set; }

		public AsientoEntity Asiento { get; set; }

		public ClienteEntity Cliente { get; set; }

		public string Numero { get; set; }

		public TipoComprobanteEntity TipoComprobante { get; set; }

		public DateTime FechaDeEmision { get; set; }

		public DateTime FechaVencimiento { get; set; }

		public RemitoClienteEntity Remito { get; set; }

		public CondicionDePagoEntity CondicionDePago { get; set; }

		public double Total { get; set; }

		public double SubTotal { get; set; }

		public double IVA { get; set; }

		public double NOGravado { get; set; }

		public double ImporteRestante { get; set; }

		public double Percepciones { get; set; }

		public string Observaciones { get; set; }

		public string CAE { get; set; }

		public string VencimientoCAE { get; set; }

		public string NumeroFacturaAFIP { get; set; }

		public string ComentariosAFIP { get; set; }

		public ZetaEntity Zeta { get; set; }

		public Boolean Eliminado { get; set; }

		public FacturaClienteEntity ()
		{
			//HACK aca no deberia inicializarse los atributos complejos
			Cliente = new ClienteEntity ();
			TipoComprobante = new TipoComprobanteEntity ();
			Remito = new RemitoClienteEntity ();
			CondicionDePago = new CondicionDePagoEntity ();
			Asiento = new AsientoEntity ();
			Zeta = new ZetaEntity ();
		}

		#region IComprobante

		IResponsable IComprobante.Responsable {
			get {
				return Cliente;
			}
		}

		string IComprobante.PuntoDeVenta {
			get {
				return TipoComprobante.Pre;
			}
		}

		IList<IItem> IComprobante.Items {
			get {
				return Remito.Renglones.Cast<IItem> ().ToList ();
			}
		}

		#endregion
	}
}
