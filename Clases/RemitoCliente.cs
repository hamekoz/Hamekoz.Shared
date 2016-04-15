using Hamekoz.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hamekoz.Negocio
{
	public class RemitoCliente : IComprobante
	{
		public long Id { get; set; }

		public Cliente Cliente { get; set; }

		public string Numero { get; set; }

		public TipoDeComprobante TipoComprobante { get; set; }

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

		public List<RemitoClienteDetalle> Renglones { get; set; }


		public RemitoCliente ()
		{
			//FIX aca no se deben iniciar los objetos
			Cliente = new Cliente ();
			TipoComprobante = new TipoDeComprobante ();
			Renglones = new List<RemitoClienteDetalle> ();
		}

		public double Total {
			get {
				return Renglones.Sum (r => r.PrecioTotal);
			}
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
				return Renglones.Cast<IItem> ().ToList ();
			}
		}

		double IComprobante.SubTotal {
			get {
				throw new NotImplementedException ();
			}
		}

		double IComprobante.IVA {
			get {
				throw new NotImplementedException ();
			}
		}

		double IComprobante.NOGravado {
			get {
				throw new NotImplementedException ();
			}
		}

		double IComprobante.Percepciones {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion
	}
}
