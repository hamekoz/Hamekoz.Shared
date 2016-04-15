using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class FacturaCliente : IComprobante
	{
		public long Id { get; set; }

		public Asiento Asiento { get; set; }

		public Cliente Cliente { get; set; }

		public string Numero { get; set; }

		public TipoDeComprobante TipoComprobante { get; set; }

		public DateTime FechaDeEmision { get; set; }

		public DateTime FechaVencimiento { get; set; }

		public RemitoCliente Remito { get; set; }

		public CondicionDePago CondicionDePago { get; set; }

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

		public Zeta Zeta { get; set; }

		public Boolean Eliminado { get; set; }

		public FacturaCliente ()
		{
			//HACK aca no deberia inicializarse los atributos complejos
			Cliente = new Cliente ();
			TipoComprobante = new TipoDeComprobante ();
			Remito = new RemitoCliente ();
			CondicionDePago = new CondicionDePago ();
			Asiento = new Asiento ();
			Zeta = new Zeta ();
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
