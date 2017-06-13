//
//  RemitoCliente.cs
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
	public class RemitoCliente : IPersistible, IIdentifiable, IComprobante, IRemito
	{
		public RemitoCliente ()
		{
			//HACK aca no se deben iniciar los objetos
			Cliente = new Cliente ();
			Tipo = new NumeracionDeComprobante ();
			Renglones = new List<RemitoClienteItem> ();
		}

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

		public NumeracionDeComprobante Tipo {
			get;
			set;
		}

		public DateTime Emision {
			get;
			set;
		}

		//FIX esto deberia ser una clase y no un atributo
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
				return Renglones.Sum(r => r.Total);
			}
		}

		#region IComprobante

		public IResponsable Responsable => Cliente;

		public string PuntoDeVenta => Tipo.Pre;

		public IList<IItem> Items => Renglones.Cast<IItem>().ToList();

		decimal IComprobante.IVA {
			get {
				throw new NotImplementedException();
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

		decimal IComprobante.Neto {
			get {
				throw new NotImplementedException ();
			}
		}

		decimal IComprobante.Tributos {
			get {
				throw new NotImplementedException ();
			}
		}

		IList<ImpuestoItem> IComprobante.Impuestos {
			get {
				return new List<ImpuestoItem> ();
			}
		}

		#endregion

		#region IRemito

		IList<IRemitoItem> IRemito.Items {
			get {
				return Renglones.Cast<IRemitoItem>().ToList();
			}
		}

		#endregion
	}
}
