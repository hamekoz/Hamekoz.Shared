//
//  ComprobanteProveedor.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//       Juan Angel Dinamarca <juan.angel.dinamarca@gmail.com>
//
//  Copyright (c) 2015 Hamekoz - www.hamekoz.com.ar
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
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	//UNDONE unificar logica comun en clase abstracta Comprobante
	//UNDONE separar datos de implementacion de comprobante electronico
	public class ComprobanteProveedor : IComprobante
	{
		public long Id {
			get;
			set;
		}

		public NumeracionDeComprobante Tipo {
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

		public DateTime Emision {
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

		public decimal Restante {
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

		public string NumeroAFIP {
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
				return Tipo.Pre;
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
