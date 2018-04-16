//
//  RemitoItem.cs
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
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class RemitoItem : IItem, IPersistible, IIdentifiable
	{
		#region IIdentifiable implementation

		public int Id {
			get;
			set;
		}

		#endregion

		public int Renglon {
			get;
			set;
		}

		public int Codigo {
			get { return Articulo.Id; }
		}

		public Articulo Articulo {
			get;
			set;
		}

		#region IItem implementation

		string IItem.Codigo {
			get { return Articulo.Id.ToString (); }
		}

		string IItem.Descripcion {
			get { return Articulo.Nombre; }
		}

		string  IItem.DescripcionCorta {
			get { return Articulo.NombreCorto; }
		}

		#region Revisar implementacion de lote

		//TODO el lote deberia ser una clase
		public int LoteId {
			get;
			set;
		}

		Lote lote;

		public Lote Lote {
			get {
				if (lote == null)
					lote = new Lote { Id = LoteId };
				return lote;
			}
			set {
				lote = value;
				if (lote != null) {
					LoteId = int.Parse (lote.Id.ToString ());	
				}
				//HACK para pasar el Id del lote a la propiedad de la clase base. Si no lo parseo por algun motivo pasa siempre 0
			}
		}

		#endregion

		//TODO revisar, el costo deberia salir del Lote
		public decimal Costo {
			get;
			set;
		}

		public decimal Cantidad {
			get;
			set;
		}

		public decimal Precio {
			get;
			set;
		}

		public decimal Neto {
			get {
				return Total - IVA - Impuestos;
			}
		}

		public decimal TasaIVA {
			get;
			set;
		}

		public decimal IVA {
			get;
			set;
		}

		public decimal Impuestos {
			get;
			set;
		}

		public decimal Total {
			get;
			set;
		}

		#endregion

		public bool VerificadoOriginal;

		public bool Verificado {
			get;
			set;
		}

		public decimal CantidadRecibida {
			get;
			set;
		}
	}
}

