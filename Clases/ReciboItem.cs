//
//  ReciboItem.cs
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
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class ReciboItem : IPersistible, IItem
	{
		internal int ReciboId;

		public Recibo Recibo {
			get;
			set;
		}

		public int Renglon {
			get;
			set;
		}

		public CuentaContable CuentaContable {
			get;
			set;
		}

		public decimal Importe {
			get;
			set;
		}

		internal int ChequeId;
		//FIX el cheque no deberia ser un atributo del detalle del recibo.
		public Cheque Cheque {
			get;
			set;
		}

		public int Lote {
			get;
			set;
		}

		#region IItem implementation

		string IItem.Codigo {
			get {
				return CuentaContable.Codigo.ToString ();
			}
		}

		string IItem.Descripcion {
			get {
				return CuentaContable.Cuenta;
			}
		}

		string IItem.DescripcionCorta {
			get {
				return CuentaContable.Cuenta.Substring (0, 40);
			}
		}

		decimal IItem.Cantidad {
			get {
				return 1;
			}
		}

		decimal IItem.Precio {
			get {
				return Importe;
			}
		}

		decimal IItem.IVA {
			get {
				return 0;
			}
		}

		decimal IItem.TasaIVA {
			get {
				return 21;
			}
		}

		decimal IItem.Impuestos {
			get {
				return 0;
			}
		}

		decimal IItem.Total {
			get {
				return Importe;
			}
		}

		#endregion
	}
}
