//
//  Asiento.cs
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
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Asiento : IPersistible, IIdentifiable
	{
		public int Id {
			get;
			set;
		}

		public string Detalle {
			get;
			set;
		}

		public DateTime Fecha {
			get;
			set;
		}

		public string Comprobante {
			get;
			set;
		}

		public DateTime FechaComprobante {
			get;
			set;
		}

		public Moneda Moneda {
			get;
			set;
		}

		//UNDONE ver si tiene sentido tener aca la empresa
		public Empresa Empresa {
			get;
			set;
		}

		public bool Eliminado { get; set; }

		public List<AsientoDetalle> Renglones { get; set; }

		public Asiento ()
		{
			Renglones = new List<AsientoDetalle> ();
		}
	}
}