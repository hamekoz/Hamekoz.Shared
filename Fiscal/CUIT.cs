//
//  CUIT.cs
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
using System.Linq;

namespace Hamekoz.Argentina
{
	public static class CUIT
	{
		public static string LimpiarCUIT (this string cuit)
		{
			return cuit.Replace ("-", string.Empty);
		}

		public static bool ValidarCUIT (this string cuit)
		{
			if (cuit == null)
				return false;
			if (cuit == string.Empty)
				return false;
			cuit = cuit.LimpiarCUIT ();
			if (cuit.Length != 11)
				return false;
			if (!cuit.All (char.IsDigit))
				return false;

			int calculado = CalcularDigitoVerificador (cuit);
			int digito = int.Parse (cuit.Substring (10));
			return calculado == digito;
		}

		static int CalcularDigitoVerificador (string cuit)
		{
			int[] mult = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
			char[] nums = cuit.ToCharArray ();
			int total = 0;
			for (int i = 0; i < mult.Length; i++) {
				total += int.Parse (nums [i].ToString ()) * mult [i];
			}
			var resto = total % 11;
			return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
		}
	}
}

