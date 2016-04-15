using Hamekoz.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hamekoz.Negocio
{
	public class RemitoProveedor : IComprobante
	{
		public long Id { get; set; }

		public Proveedor Proveedor { get; set; }

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

		public List<RemitoProveedorDetalle> Renglones { get; set; }


		public RemitoProveedor ()
		{
			//FIX aca no se deben iniciar objetos
			Proveedor = new Proveedor ();
			TipoComprobante = new TipoDeComprobante ();
			Renglones = new List<RemitoProveedorDetalle> ();
		}

		#region IComprobante

		IResponsable IComprobante.Responsable {
			get {
				return Proveedor;
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

		double IComprobante.Total {
			get {
				return Renglones.Sum (r => r.PrecioTotal);
			}
		}

		double IComprobante.SubTotal {
			get {
				return Renglones.Sum (r => r.Neto);
			}
		}

		double IComprobante.IVA {
			get {
				return Renglones.Sum (r => r.IVA);
			}
		}

		double IComprobante.NOGravado {
			get {
				return Renglones.Sum (r => r.TotalImpuestos);
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
