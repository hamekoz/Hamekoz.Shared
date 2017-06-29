//
//  IVAItem.cs
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
using System.Collections.Generic;
using System.ComponentModel;

namespace Hamekoz.Negocio
{
	public enum IVA
	{
		/// <summary>
		/// IVA GENERAL 21 %
		/// </summary>
		[DescriptionAttribute ("IVA GENERAL 21 %")]
		General,
		/// <summary>
		/// IVA EXENTO 0 %
		/// </summary>
		[DescriptionAttribute ("IVA EXENTO 0 %")]
		Exento,
		/// <summary>
		/// IVA DIFERENCIAL 10.5 %
		/// </summary>
		[DescriptionAttribute ("IVA DIFERENCIAL 10.5 %")]
		Diferencial1,
		/// <summary>
		/// IVA DIFERENCIAL 27 %
		/// </summary>
		[DescriptionAttribute ("IVA DIFERENCIAL 27 %")]
		Diferencial2,
		/// <summary>
		/// IVA DIFERENCIAL 2.5 %
		/// </summary>
		[DescriptionAttribute ("IVA DIFERENCIAL 2.5 %")]
		Diferencial3,
		/// <summary>
		/// IVA DIFERENCIAL 5 %
		/// </summary>
		[DescriptionAttribute ("IVA DIFERENCIAL 5 %")]
		Diferencial4,
	}

	public static class IVAExtension
	{
		public static decimal Alicuota (this IVA iva)
		{
			switch (iva) {
			case IVA.General:
				return 21m;
			case IVA.Diferencial1:
				return 10.5m;
			case IVA.Diferencial2:
				return 27m;
			case IVA.Diferencial3:
				return 2.5m;
			case IVA.Diferencial4:
				return 5m;
			case IVA.Exento:
				return 0m;	
			default:
				return 21m;
			}
		}
	}

	public class IVAItem
	{
		public IVA IVA {
			get;
			set;
		}

		public decimal Neto {
			get;
			set;
		}

		public decimal Alicuota {
			get;
			set;
		}

		public decimal Importe {
			get;
			set;
		}
	}
}

