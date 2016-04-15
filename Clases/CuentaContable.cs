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
			private set;
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

		public string IDescriptible.Descripcion {
			get {
				return ToString ();
			}
		}
	}
}
