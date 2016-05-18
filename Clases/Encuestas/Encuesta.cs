﻿//
//  Encuesta.cs
//
//  Author:
//       Mariano Ripa <ripamariano@gmail.com>
//
//  Copyright (c) 2016 Hamekoz
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
using System.Linq;

namespace Hamekoz.Negocio
{
	public abstract class Encuesta
	{

		public string Nombre { get; set; }

		public short Puntaje { get; set; }

		public DateTime Fecha { get; set; }

		public int TotalPreguntas {
			get {
				return Secciones != null ? Secciones.Sum (i => i.NroPreguntas) : 0;
			}
		
		}


		public int NroSecciones {
			get {
				return Secciones != null ? Secciones.Count : 0;
			}

		}

		public IList<EncuestaSeccion> Secciones { get; set; }


	}
}

