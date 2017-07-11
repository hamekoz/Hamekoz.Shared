//
//  AsientoItem.cs
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
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class AsientoItem : IPersistible, IIdentifiable
	{
		//HACK no deberia tener constructor
		public AsientoItem ()
		{
			CuentaContable = new CuentaContable ();
			CentroDeCosto = new CentroDeCosto ();
		}

		public int Id {
			get;
			set;
		}

		public CuentaContable CuentaContable {
			get;
			set;
		}

		internal Cotizacion Cotizacion {
			get;
			set;
		}

		public decimal Debe {
			get;
			set;
		}

		public decimal Haber {
			get;
			set;
		}

		public CentroDeCosto CentroDeCosto {
			get;
			set;
		}

		//UNDONE aca el comprobante debe ser una clase base de todos los comprobantes
		public int comprobanteId;
		public decimal cotizacionDelPeso = 1;
	}
}
