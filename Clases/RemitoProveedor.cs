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

		decimal IComprobante.Gravado {
			get {
				throw new NotImplementedException ();
			}
		}

		decimal IComprobante.Exento {
			get {
				throw new NotImplementedException ();
			}
		}

		decimal IComprobante.Tributos {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion
	}
}
