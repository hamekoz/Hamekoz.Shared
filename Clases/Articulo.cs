//
//  Articulo.cs
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

namespace Hamekoz.Negocio
{
	public class Articulo : IPersistible, IIdentifiable, IDescriptible
	{
		public int Id {
			get;
			set;
		}

		public string Nombre {
			get;
			set;
		}

		public string Codigo {
			get;
			set;
		}

		public string NombreCorto {
			get;
			set;
		}

		public decimal Precio {
			get;
			set;
		}

		public decimal TasaDeIVA {
			get;
			set;
		}

		public decimal IVA {
			get {
				return Math.Round (Precio - Precio / (1 + TasaDeIVA / 100), 2);
			}
		}

		public decimal ImpuestosInternos {
			get;
			set;
		}

		public decimal Neto {
			get {
				return Math.Round (Precio - IVA - ImpuestosInternos, 2);
			}
		}

		public Medidas Medida {
			get;
			set;
		}

		public Rubro Rubro {
			get;
			set;
		}

		public Estados Estado {
			get;
			set;
		}

		public Articulo ()
		{
			TasaDeIVA = 21;
		}

		string IDescriptible.Descripcion {
			get {
				return Nombre;
			}
		}
	}
}