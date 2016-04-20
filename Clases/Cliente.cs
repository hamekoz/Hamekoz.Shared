//
//  Cliente.cs
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
using Hamekoz.Fiscal;
using System.Collections.Generic;

namespace Hamekoz.Negocio
{
	public class Cliente : IPersistible, IIdentifiable, IDescriptible, IResponsable
	{
		public int Id {
			get;
			set;
		}

		public string CUIT {
			get;
			set;
		}

		public string IIBB {
			get;
			set;
		}

		public string DNI {
			get;
			set;
		}

		public string RazonSocial {
			get;
			set;
		}

		public Domicilio Domicilio {
			get;
			set;
		}

		public CondicionDePago CondicionDePago {
			get;
			set;
		}

		public Estados EstadoCliente {
			get;
			set;
		}

		public SituacionIVA CondicionDeIVA {
			get;
			set;
		}

		public CondicionDeIngresosBrutos CondicionIngresosBrutos {
			get;
			set;
		}

		public IList<Telefono> Telefonos {
			get;
			set;
		}

		//UNDONE aca podria ser una lista de correos electronicos
		public string Email {
			get;
			set;
		}

		public long TarjetaFidelizacion {
			get;
			set;
		}

		public ListaDePrecios ListaDePrecios {
			get;
			set;
		}

		//Esto deberia tener algun otro nombre para contemplar a las personas juridicas
		public DateTime FechaDeNacimiento {
			get;
			set;
		}

		public Cliente ()
		{
			CUIT = string.Empty;
			RazonSocial = string.Empty;
			CondicionDeIVA = SituacionIVA.CONSUMIDOR_FINAL;
			EstadoCliente = Estados.Gestion;
		}

		public override string ToString ()
		{
			return RazonSocial;
		}

		string IDescriptible.Descripcion {
			get {
				return RazonSocial;
			}
		}

		string IResponsable.Domicilio {
			get {
				return Domicilio.ToString ();
			}
		}
	}
}
