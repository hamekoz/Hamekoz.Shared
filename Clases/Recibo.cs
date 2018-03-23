﻿//
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
	public class Recibo : Comprobante, IPersistible , IComprobante, ISearchable
	{
		public Recibo ()
		{
			//FIX aca no se deben iniciar los objetos
			Cliente = new Cliente ();
			Tipo = new NumeracionDeComprobante ();
			Renglones = new List<ReciboItem> ();
		}

		public Cliente Cliente {
			get {
				return (Cliente)Responsable;
			}
			set {
				Responsable = value;
			}
		}

		public IList<ReciboItem> Renglones {
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

		[System.Obsolete ("Usar propidade Anulado")]
		public bool Eliminado {
			get {
				return Anulado;
			}
			set {
				Anulado = value;
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
				return Tipo.Pre;
			}
		}

		IList<IItem> IComprobante.Items {
			get {
				return Renglones.Cast<IItem> ().ToList ();
			}
		}

		decimal IComprobante.Tributos {
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

		public override string ToString ()
		{
			return string.Format ("{0} {1} {2}", Tipo.Abreviatura, Tipo.Letra, Numero);
		}

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
