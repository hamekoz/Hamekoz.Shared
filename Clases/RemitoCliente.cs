using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class RemitoCliente : IPersistible, IIdentifiable, IComprobante
	{
		public int Id {
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

		public TipoDeComprobante TipoDeComprobante {
			get;
			set;
		}

		public DateTime FechaDeEmision {
			get;
			set;
		}

		public int IdFlete {
			get;
			set;
		}
		//FIX ver si realmente debe estar aca esta propiedad
		public Pedido Pedido {
			get;
			set;
		}

		//pasar a objeto (todavia no se usa)
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

		public List<RemitoClienteItem> Renglones {
			get;
			set;
		}

		public decimal Total {
			get {
				return Renglones.Sum (r => r.Total);
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
				return TipoDeComprobante.Pre;
			}
		}

		IList<IItem> IComprobante.Items {
			get {
				return Renglones.Cast<IItem> ().ToList ();
			}
		}

		decimal IComprobante.SubTotal {
			get {
				throw new NotImplementedException ();
			}
		}

		decimal IComprobante.IVA {
			get {
				throw new NotImplementedException ();
			}
		}

		decimal IComprobante.NoGravado {
			get {
				throw new NotImplementedException ();
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
