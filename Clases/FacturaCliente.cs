using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	//UNDONE unificar logica comun en clase abstracta Comprobante
	//UNDONE separar datos de implementacion de comprobante electronico
	//UNDONE separar datos de implementacion de comprobante por controlador fiscal
	public class FacturaCliente : IComprobante
	{
		public int Id {
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

		public Cliente Cliente {
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

		public RemitoCliente Remito {
			get;
			set;
		}

		public CondicionDePago CondicionDePago {
			get;
			set;
		}

		public decimal Total {
			get;
			set;
		}

		public decimal SubTotal {
			get;
			set;
		}

		public decimal IVA {
			get;
			set;
		}

		public decimal NoGravado {
			get;
			set;
		}

		public decimal ImporteRestante {
			get;
			set;
		}

		public decimal Percepciones {
			get;
			set;
		}

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

		public Zeta Zeta {
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
