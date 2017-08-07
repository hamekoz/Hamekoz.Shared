//
//  Recibo.cs
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
using System.Collections.Generic;
using System.Linq;
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	//UNDONE unificar logica comun en clase abstracta Comprobante
	public class Recibo : Comprobante, IPersistible , IComprobante, ISearchable
	{
		public Recibo ()
		{
			//FIX aca no se deben iniciar los objetos
			Cliente = new Cliente ();
			Tipo = new NumeracionDeComprobante ();
			Renglones = new List<ReciboItem> ();
			Asiento = new Asiento ();
		}

		public Cliente Cliente {
			get {
				return (Cliente)Responsable;
			}
			set {
				Responsable = value;
			}
		}

		public List<ReciboItem> Renglones {
			get;
			set;
		}

		public string CAE {
			get;
			set;
		}

		public string VencimientoCAE {
			get;
			set;
		}

		public string NumeroComprobanteAFIP {
			get;
			set;
		}

		public string ComentariosAFIP {
			get;
			set;
		}

		public bool Eliminado {
			get;
			set;
		}

		[Obsolete ("Usar IVAs")]
		public decimal NetoGeneral { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.General);
				return ivaItem == null ? 0 : ivaItem.Neto;
			}
		}

		[Obsolete ("Usar IVAs")]
		public decimal NetoDiferencial1 { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.Diferencial1);
				return ivaItem == null ? 0 : ivaItem.Neto;
			}
		}

		[Obsolete ("Usar IVAs")]
		public decimal NetoDiferencial2 { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.Diferencial2);
				return ivaItem == null ? 0 : ivaItem.Neto;
			}
		}

		[Obsolete ("Usar IVAs")]
		public decimal NetoDiferencial3 { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.Diferencial3);
				return ivaItem == null ? 0 : ivaItem.Neto;
			}
		}

		[Obsolete ("Usar IVAs")]
		public decimal NoInscripto { get; set; }

		[Obsolete ("Usar IVAs")]
		public decimal IvaGeneral { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.General);
				return ivaItem == null ? 0 : ivaItem.Importe;
			}
		}

		[Obsolete ("Usar IVAs")]
		public decimal IvaDiferencial1 { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.Diferencial1);
				return ivaItem == null ? 0 : ivaItem.Importe;
			}
		}

		[Obsolete ("Usar IVAs")]
		public decimal IvaDiferencial2 { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.Diferencial2);
				return ivaItem == null ? 0 : ivaItem.Importe;
			}
		}

		[Obsolete ("Usar IVAs")]
		public decimal IvaDiferencial3 { 
			get { 
				var ivaItem = IVAItems.FirstOrDefault (i => i.IVA == Hamekoz.Negocio.IVA.Diferencial3);
				return ivaItem == null ? 0 : ivaItem.Importe;
			}
		}

		//TODO mapear al impuesto correspondiente
		[Obsolete ("Usar Impuestos")]
		public decimal PercepcionIva { get; set; }

		//TODO mapear al impuesto correspondiente
		[Obsolete ("Usar Impuestos")]
		public decimal IBCapital { get; set; }

		//TODO mapear al impuesto correspondiente
		[Obsolete ("Usar Impuestos")]
		public decimal IBBsAs { get; set; }


		#region IComprobante

		IResponsable IComprobante.Responsable {
			get {
				return Cliente;
			}
		}

		string IComprobante.PuntoDeVenta {
			get {
				return Tipo.Pre;
			}
		}

		IList<IItem> IComprobante.Items {
			get {
				return Renglones.Cast<IItem> ().ToList ();
			}
		}

		decimal IComprobante.Tributos {
			get {
				return 0;
			}
		}

		string IComprobante.Observaciones {
			get {
				return string.Empty;
			}
		}

		#endregion

		public override string ToString ()
		{
			return string.Format ("{0} {1} {2}", Tipo.Abreviatura, Tipo.Letra, Numero);
		}

		#region ISearchable implementation

		public string ToSearchString ()
		{
			return string.Format ("[Recibo: Id={0}, Asiento={1}, Cliente={2}, Numero={3}]"
				, Id
				, Asiento
				, Cliente
				, Numero);
		}

		#endregion
	}
}
