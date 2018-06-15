﻿//
//  CentroDeCosto.cs
//
//  Author:
//       Ezequiel Taranto <ezequiel89@gmail.com>
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
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
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public partial class CentroDeCosto : IPersistible, IIdentifiable, IDescriptible
	{
		#region IPersistible implementation

		public int Id { get; set; }

		#endregion

		public string Descripcion { get; set; } = string.Empty;

		public bool Inactivo { get; set; }

		public override string ToString ()
		{
			return Descripcion;
		}
	}
}
