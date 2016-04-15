using System;
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class Cliente : IDescriptible, IResponsable
	{
		public enum Estados
		{
			Activo = 1,
			Gestion = 2,
			Baja = 3,
		}

		public int Id { get; set; }

		public string CUIT { get; set; }

		public string IIBB { get; set; }

		public string DNI { get; set; }

		public string RazonSocial { get; set; }

		public string Domicilio { get; set; }

		public string Localidad { get; set; }

		public string CP { get; set; }

		public CondicionDePago CondicionDePago { get; set; }

		public Estados EstadoCliente { get; set; }

		public SituacionIVA CondicionDeIVA { get; set; }

		public CondicionDeIngresosBrutos CondicionIngresosBrutos { get; set; }

		public string Telefono1 { get; set; }

		public string Telefono2 { get; set; }

		public string Telefono3 { get; set; }

		public string Email { get; set; }

		public long IdTarjetaFidelizacion { get; set; }

		public ListaDePrecios ListaDePrecios { get; set; }

		public DateTime FechaDeNacimiento { get; set; }

		public Cliente ()
		{
			CUIT = string.Empty;
			RazonSocial = string.Empty;
			CondicionDeIVA = SituacionIVA.CONSUMIDOR_FINAL;
			CondicionDePago = new CondicionDePago ();
			EstadoCliente = Estados.Gestion;
			CondicionIngresosBrutos = new CondicionDeIngresosBrutos ();
			ListaDePrecios = new ListaDePrecios ();

		}

		public override string ToString ()
		{
			return RazonSocial;
		}

		public string Descripcion {
			get {
				return RazonSocial;
			}
		}
	}
}
