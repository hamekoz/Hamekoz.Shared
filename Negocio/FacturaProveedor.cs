using Hamekoz.Fiscal;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Hamekoz.Negocio
{
	public class FacturaProveedor : IComprobante
	{
		public long Id { get; set; }

		public Asiento Asiento { get; set; }

		public Proveedor Proveedor { get; set; }

		public string Numero { get; set; }

		public TipoDeComprobante TipoComprobante { get; set; }

		public DateTime FechaDeEmision { get; set; }

		public DateTime FechaVencimiento { get; set; }

		public RemitoProveedor Remito { get; set; }

		public CondicionDePago CondicionDePago { get; set; }

		double total;

		public double Total {
			get { return Math.Round (total, 2); }
			set { total = value; }
		}

		double subTotal;

		public double SubTotal {
			get { return Math.Round (subTotal, 2); }
			set { subTotal = value; }
		}

		double ivaInscripto;

		public double IVA {
			get { return Math.Round (ivaInscripto, 2); }
			set { ivaInscripto = value; }
		}

		public double NOGravado { get; set; }

		public double ImporteRestante { get; set; }
		//   public MonedaEntity Moneda { get; set; }
		public string Observaciones { get; set; }

		public string CAE { get; set; }

		public string VencimientoCAE { get; set; }

		public string NumeroFacturaAFIP { get; set; }

		public string ComentariosAFIP { get; set; }

		public Boolean Eliminado { get; set; }

		public FacturaProveedor ()
		{
			//FIX aca no debria inicializase los objetos
			Proveedor = new Proveedor ();
			TipoComprobante = new TipoDeComprobante ();
			Remito = new RemitoProveedor ();
			CondicionDePago = new CondicionDePago ();
			Asiento = new Asiento ();
			Observaciones = string.Empty;
		}

		public double Percepciones { get; set; }

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
				return Remito.Renglones.Cast<IItem> ().ToList ();
			}
		}

		#endregion
	}
}
