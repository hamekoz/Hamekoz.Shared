//
//  Deposito.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2014 Hamekoz - www.hamekoz.com.ar
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
	public class Deposito : IPersistible, IIdentifiable, IDescriptible
	{
		//TODO Revisar porque un deposito puede llegar a tener mas de un Rol
		public enum Tipos
		{
			Almacenaje = 1,
			Productivo = 2,
			Expeditivo = 3,
			Especial = 4
		}

		public int Id {
			get;
			set;
		}

		public string Nombre {
			get;
			set;
		}

		[Obsolete ("Usar el campo Nombre")]
		public string Descripcion {
			get {
				return Nombre;
			}
			set {
				Nombre = value;
			}
		}

		public Tipos Tipo {
			get;
			set;
		}

		public override string ToString ()
		{
			return Nombre;
		}
	}
}
