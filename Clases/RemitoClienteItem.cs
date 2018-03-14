//
//  RemitoClienteItem.cs
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
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class RemitoClienteItem : RemitoItem, IItem, IRemitoItem
	{
		//UNDONE Los valores deben calcularse solo si no esta grabado el remito, en caso contrario son lectura directa
		double porcentaje;

		public void SetPorcentaje (double porcentaje)
		{
			this.porcentaje = porcentaje;
		}

		public IRemito Remito {
			get;
			set;
		}

		public int Renglon {
			get;
			set;
		}

		public Articulo Articulo {
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

		public decimal Total {
			get {
				return Math.Round (Precio * Cantidad, 2);
			}
		}

		public decimal Neto {
			get {
				return Math.Round (Articulo.Neto * Cantidad * (1 + (decimal)porcentaje / 100), 2);
			}
		}

		public decimal Impuestos {
			get {
				return Math.Round (Articulo.ImpuestosInternos * Cantidad * (1 + (decimal)porcentaje / 100), 2);
			}
		}

		public decimal IVA {
			get {
				return Math.Round (Articulo.IVA * Cantidad * (1 + (decimal)porcentaje / 100), 2);
			}
		}

		public decimal TasaIVA {
			get {
				return Articulo.TasaDeIVA;
			}
		}

		public Lote Lote {
			get;
			set;
		}

		public decimal Costo {
			get;
			set;
		}

		#region IItem

		string IItem.Codigo {
			get {
				return Articulo.Codigo;
			}
		}

		int IItem.Lote {
			get {
				return Lote.Id;
			}
		}

		string IItem.Descripcion {
			get {
				return Articulo.Nombre;
			}
		}

		string IItem.DescripcionCorta {
			get {
				return Articulo.NombreCorto;
			}
		}

		#endregion
	}
}
