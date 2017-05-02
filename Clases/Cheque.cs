//
//  Cheque.cs
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
	public class Cheque : IPersistible, IIdentifiable
	{
		public enum Estados
		{
			EnCartera = 1,
			Rechazado,
			Depositado,
			Endosado,
			Emitido,
			Anulado
		}

		#region IIdentifiable implementation

		public int Id { get; set; }

		#endregion

		public Banco Banco {
			get;
			set;
		}

		public Estados Estado {
			get;
			set;
		}

		public DateTime Emision {
			get;
			set;
		}

		public DateTime Cobro {
			get;
			set;
		}

		public int Numero {
			get;
			set;
		}

		public decimal Importe {
			get;
			set;
		}

		public override string ToString ()
		{
			return string.Format ("Cheque: Banco {0} Emision {1:d} Cobro {2:d} Numero {3} Importe {4:C}", Banco, Emision, Cobro, Numero, Importe);
		}
	}
}

