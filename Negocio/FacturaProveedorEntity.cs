using Hamekoz.Fiscal;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Hamekoz.Negocio
{
	public class FacturaProveedorEntity : IComprobante
	{
		public long Id { get; set; }

		public AsientoEntity Asiento { get; set; }

		public ProveedorEntity Proveedor { get; set; }

		public string Numero { get; set; }

		public TipoComprobanteEntity TipoComprobante { get; set; }

		public DateTime FechaDeEmision { get; set; }

		public DateTime FechaVencimiento { get; set; }

		public RemitoProveedorEntity Remito { get; set; }

		public CondicionDePagoEntity CondicionDePago { get; set; }

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

		public FacturaProveedorEntity ()
		{
			//FIX aca no debria inicializase los objetos
			Proveedor = new ProveedorEntity ();
			TipoComprobante = new TipoComprobanteEntity ();
			Remito = new RemitoProveedorEntity ();
			CondicionDePago = new CondicionDePagoEntity ();
			Asiento = new AsientoEntity ();
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
