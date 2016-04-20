//
//  ComprobanteCliente.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//       Ezequiel Taranto <ezequiel89@gmail.com>
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
	//UNDONE separar datos de implementacion de comprobante por controlador fiscal
	public class ComprobanteCliente : IComprobante
	{
		public int Id {
			get;
			set;
		}

		public TipoDeComprobante Tipo {
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

		public DateTime Emision {
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

		public decimal Restante {
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

		public string NumeroAFIP {
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
