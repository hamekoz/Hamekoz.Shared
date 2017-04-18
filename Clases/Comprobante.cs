//
//  Comprobante.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2017 Hamekoz - www.hamekoz.com.ar
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
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class Comprobante : IComprobante, IComprobanteImputable
	{
		public int Id {
			get;
			set;
		}

		public IResponsable Responsable {
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

		//TODO verificar que tenga sentido el Remito en la clase base Comprobante, es mas bien un dato de una Factura derivada de Comprobante
		public IRemito Remito {
			get;
			set;
		}

		public Cotizacion Cotizacion {
			get;
			set;
		}

		public IList<IItem> Items {
			get;
			set;
		}

		public IList<ImpuestoItem> Impuestos {
			get;
			set;
		}

		public decimal Gravado {
			get;
			set;
		}

		public decimal Exento {
			get;
			set;
		}


		public decimal IVA {
			get;
			set;
		}

		public decimal Tributos {
			get;
			set;
		}

		public decimal Total {
			get;
			set;
		}

		public IList<Imputacion> Imputaciones {
			get;
			set;
		}

		public decimal Imputado {
			get;
			set;
		}

		public decimal Restante {
			get;
			set;
		}

		public string Observaciones {
			get;
			set;
		}

		public override string ToString ()
		{
			return string.Format ("{0} {1} {2}", Tipo.Abreviatura, Tipo.Letra, Numero);
		}

		public string PuntoDeVenta {
			get {
				throw new NotImplementedException ();
			}
		}

		[Obsolete ("Usar Gravado")]
		public decimal SubTotal {
			get {
				return Gravado;
			}
			set {
				Gravado = value;
			}
		}

		[Obsolete ("Usar Exento")]
		public decimal NoGravado {
			get {
				return Exento;
			}
			set {
				Exento = value;
			}
		}

		[Obsolete ("Usar Tributos")]
		public decimal Percepciones {
			get {
				return Tributos;
			}
			set {
				Tributos = value;
			}
		}
	}
}

