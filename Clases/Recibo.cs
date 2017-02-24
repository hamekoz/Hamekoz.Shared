//
//  Recibo.cs
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
	//UNDONE unificar logica comun en clase abstracta Comprobante
	public class Recibo : IPersistible, IIdentifiable, IComprobante, ISearchable
	{
		public Recibo ()
		{
			//FIX aca no se deben iniciar los objetos
			Cliente = new Cliente ();
			TipoComprobante = new NumeracionDeComprobante ();
			Renglones = new List<ReciboItem> ();
			Asiento = new Asiento ();
		}

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

		public NumeracionDeComprobante TipoComprobante {
			get;
			set;
		}

		public DateTime Emision {
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

		public decimal Restante {
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

		#region ISearchable implementation

		public string ToSearchString ()
		{
			return string.Format ("[Recibo: Id={0}, Asiento={1}, Cliente={2}, Numero={3}]"
				, Id
				, Asiento
				, Cliente
				, Numero);
		}

		#endregion
	}
}
