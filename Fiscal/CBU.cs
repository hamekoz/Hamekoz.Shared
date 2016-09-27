//
//  CBU.cs
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
	public static class CBU
	{
		public static bool ValidarCBU (this string cbu)
		{
			if (cbu == null)
				return false;
			if (cbu == string.Empty)
				return false;
			cbu = cbu.Replace ("-", string.Empty);
			cbu = cbu.Replace (" ", string.Empty);
			if (cbu.Length != 22)
				return false;
			if (!cbu.All (char.IsDigit))
				return false;

			//TODO completar algoritmo de verificacion
			//https://es.wikipedia.org/wiki/Clave_Bancaria_Uniforme
			return true;
		}
	}
}

