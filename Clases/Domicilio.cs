//
//  Domicilio.cs
//
//  Author:
//       Ezequiel Taranto <ezequiel89@gmail.com>
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//       Mariano Adrian Ripa <ripamariano@gmail.com>
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
	public class Domicilio : IPersistible, IIdentifiable
	{
		public int Id {
			get;
			set;
		}

		public Localidad Localidad {
			get;
			set;
		}

		public string CodigoPostal {
			get;
			set;
		}


		public string Calle {
			get;
			set;
		}

		public string Numero {
			get;
			set;
		}

		public string Departarmento {
			get;
			set;
		}

		public string ToDomicilio ()
		{
			var build = new System.Text.StringBuilder ();
			build.Append (Calle);
			if (Numero != string.Empty) {
				build.Append (" ");
				build.Append (Numero);
			}
			if (Departarmento != string.Empty) {
				build.Append (" ");
				build.Append (Departarmento);
			}
			return build.ToString ();
		}

		public override string ToString ()
		{
			var build = new System.Text.StringBuilder ();
			build.Append (ToDomicilio ());
//			if (Localidad?.Nombre != string.Empty) {
//				build.Append (" - ");
//				build.Append (Localidad.Nombre);
//			}
//			if (Localidad?.Municipio?.Nombre != string.Empty) {
//				build.Append (" - ");
//				build.Append (Localidad?.Municipio?.Nombre);
//			}
//			if (Localidad?.Municipio?.Nombre != string.Empty) {
//				build.Append (" - ");
//				build.Append (Localidad?.Municipio?.Nombre);
//			}
//			if (Localidad?.Municipio?.Provincia?.Nombre != string.Empty) {
//				build.Append (" - ");
//				build.Append (Localidad?.Municipio?.Provincia?.Nombre);
//			}
//			if (Localidad?.Municipio?.Provincia?.Pais?.Nombre != string.Empty) {
//				build.Append (" - ");
//				build.Append (Localidad?.Municipio?.Provincia?.Pais?.Nombre);
//			}
			return build.ToString ();
		}
	}
}

