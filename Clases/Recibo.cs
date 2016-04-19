using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	//UNDONE unificar logica comun en clase abstracta Comprobante
	public class Recibo : IPersistible, IIdentifiable, IComprobante
	{
		public int Id {
			get;
			set;
		}

		public Asiento Asiento {
			get;
			set;
		}

		public Cliente Cliente {
			get;
			set;
		}

		public string Numero {
			get;
			set;
		}

		public TipoDeComprobante TipoComprobante {
			get;
			set;
		}

		public DateTime FechaDeEmision {
			get;
			set;
		}

		decimal total;

		public decimal Total {
			get { return Math.Round (total, 2); }
			set { total = value; }
		}

		decimal subTotal;

		public decimal SubTotal {
			get { return Math.Round (subTotal, 2); }
			set { subTotal = value; }
		}

		decimal ivaInscripto;

		public decimal IVA {
			get { return Math.Round (ivaInscripto, 2); }
			set { ivaInscripto = value; }
		}

		public decimal NoGravado {
			get;
			set;
		}

		public decimal ImporteRestante {
			get;
			set;
		}

		public List<ReciboItem> Renglones {
			get;
			set;
		}

		public string CAE {
			get;
			set;
		}

		public string VencimientoCAE {
			get;
			set;
		}

		public string NumeroComprobanteAFIP {
			get;
			set;
		}

		public string ComentariosAFIP {
			get;
			set;
		}

		public bool Eliminado {
			get;
			set;
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

		decimal IComprobante.Percepciones {
			get {
				return 0;
			}
		}

		string IComprobante.Observaciones {
			get {
				return string.Empty;
			}
		}

		#endregion
	}
}
