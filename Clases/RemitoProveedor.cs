//
//  RemitoProveedor.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2016 Hamekoz - www.hamekoz.com.ar
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	//FIX IRemito, deberia implementar IComprobante
	public class RemitoProveedor : IPersistible, IIdentifiable, IComprobante, IComprobanteBase, IRemito
	{
		#region IPersistible implementation

		public int Id {
			get;
			set;
		}

		#endregion

		public Proveedor Proveedor {
			get;
			set;
		}

		public string Numero {
			get;
			set;
		}

		public NumeracionDeComprobante Tipo {
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

		public override string ToString ()
		{
			return string.Format ("{0} {1} {2}", Tipo.Abreviatura, Tipo.Letra, Numero);
		}

		#region IRemito

		IList<IRemitoItem> IRemito.Items {
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

		decimal IComprobante.IVA {
			get {
				return Renglones.Sum (r => r.IVA);
			}
		}

		decimal IComprobante.Gravado {
			get {
				return Renglones.Sum (r => r.Neto);
			}
		}

		decimal IComprobante.Exento {
			get {
				throw new NotImplementedException ();
			}
		}

		decimal IComprobante.Tributos {
			get {
				return Renglones.Sum (r => r.TotalImpuestos);
			}
		}

		#endregion

		#region IComprobanteBase

		string IComprobanteBase.Comprobante {
			get {
				return ToString ();
			}
		}

		DateTime IComprobanteBase.Emision {
			get { 
				return Emision.Date;
			}
		}

		IResponsable IComprobanteBase.Responsable {
			get {
				return Proveedor;
			}
		}

		decimal IComprobanteBase.Total {
			get {
				return 0;
			}
		}

		#endregion
	}
}
