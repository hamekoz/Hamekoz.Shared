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
