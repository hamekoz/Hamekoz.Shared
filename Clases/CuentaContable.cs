﻿//
//  CuentaContable.cs
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
	public class CuentaContable : IPersistible, IIdentifiable, IDescriptible
	{
		//UNDONE Confirmar los tipos de cuentas contables que puede haber
		public enum Tipos
		{
			SinDato,
			Efectivo,
			Cheque,
		}

		public int Id {
			get;
			set;
		}

		public int Codigo {
			get;
			set;
		}

		public string Cuenta {
			get;
			set;
		}

		public CuentaContable Suma {
			get;
			set;
		}

		public bool Modificable {
			get;
			set;
		}

		public Tipos Tipo {
			get;
			set;
		}

		public Moneda Moneda {
			get;
			set;
		}

		public bool RecibeAsientos {
			get;
			set;
		}

		public double Saldo {
			get;
			set;
		}

		public double SaldoDiferido {
			get;
			set;
		}

		//UNDONE verificar si tiene sentido que sea una propiedad
		public bool Eliminado {
			get;
			set;
		}

		public override string ToString ()
		{
			return Codigo + " " + Cuenta;
		}

		string IDescriptible.Descripcion {
			get {
				return ToString ();
			}
		}
	}
}
