using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	//UNDONE unificar logica comun en clase abstracta Comprobante
	//UNDONE separar datos de implementacion de comprobante electronico
	public class FacturaProveedor : IComprobante
	{
		public long Id {
			get;
			set;
		}

		public TipoDeComprobante TipoDeComprobante {
			get;
			set;
		}

		public string Numero {
			get;
			set;
		}

		public Asiento Asiento {
			get;
			set;
		}

		public Proveedor Proveedor {
			get;
			set;
		}

		public DateTime FechaDeEmision {
			get;
			set;
		}

		public DateTime Vencimiento {
			get;
			set;
		}

		public RemitoProveedor Remito {
			get;
			set;
		}

		public CondicionDePago CondicionDePago {
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

		decimal iva;

		public decimal IVA {
			get { return Math.Round (iva, 2); }
			set { iva = value; }
		}

		public decimal NoGravado {
			get;
			set;
		}

		public decimal ImporteRestante {
			get;
			set;
		}
		//   public MonedaEntity Moneda { get; set; }

		public string Observaciones {
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

		public string NumeroFacturaAFIP {
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

		public decimal Percepciones {
			get;
			set;
		}

		#region IComprobante

		IResponsable IComprobante.Responsable {
			get {
				return Proveedor;
			}
		}

		string IComprobante.PuntoDeVenta {
			get {
				return TipoDeComprobante.Pre;
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
