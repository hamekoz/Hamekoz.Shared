using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	//FIX IRemito, deberia implementar IComprobante
	public class RemitoProveedor : IPersistible, IIdentifiable, IComprobante, IRemito
	{
		public int Id {
			get;
			set;
		}

		public Proveedor Proveedor {
			get;
			set;
		}

		public string Numero {
			get;
			set;
		}

		public TipoDeComprobante Tipo {
			get;
			set;
		}

		public DateTime Emision {
			get;
			set;
		}

		//UNDONE esto deberia ser una clase
		public int IdFlete {
			get;
			set;
		}

		public Pedido Pedido {
			get;
			set;
		}

		public int Bultos {
			get;
			set;
		}

		public decimal ValorAsegurado {
			get;
			set;
		}

		public Domicilio DomicilioDeEntrega {
			get;
			set;
		}

		public string Observaciones {
			get;
			set;
		}

		public List<RemitoProveedorItem> Renglones {
			get;
			set;
		}

		#region IRemito

		IList<IRemitoItem> IRemito.Renglones {
			get {
				return Renglones.Cast<IRemitoItem> ().ToList ();
			}
		}

		#endregion


		#region IComprobante

		IResponsable IComprobante.Responsable {
			get {
				return Proveedor;
			}
		}

		string IComprobante.PuntoDeVenta {
			get {
				return Tipo.Pre;
			}
		}

		IList<IItem> IComprobante.Items {
			get {
				return Renglones.Cast<IItem> ().ToList ();
			}
		}

		decimal IComprobante.Total {
			get {
				return Renglones.Sum (r => r.Total);
			}
		}

		decimal IComprobante.SubTotal {
			get {
				return Renglones.Sum (r => r.Neto);
			}
		}

		decimal IComprobante.IVA {
			get {
				return Renglones.Sum (r => r.IVA);
			}
		}

		decimal IComprobante.NoGravado {
			get {
				return Renglones.Sum (r => r.TotalImpuestos);
			}
		}

		decimal IComprobante.Percepciones {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion
	}
}
