using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	//TODO: Falta agregar CuentasBase
	public class CuentaContable : IDescriptible
	{
		public int Id { get; set; }

		public int IdCuentaContableSuma { get; set; }

		public int IdCuentaBase { get; set; }

		public string Cuenta { get; set; }

		public Boolean RecibeAsientos { get; set; }

		public double Saldo { get; set; }

		public double SaldoDiferido { get; set; }

		public Moneda Moneda { get; set; }

		public TipoDeCuentaContable TipoCuenta { get; set; }
		// SIN DATO / EFECTIVO / CHEQUE
		public Boolean Modificable { get; set; }

		public Banco Banco { get; set; }

		public int CodigoCuentaContable{ get; set; }

		public int Tabulacion { get; set; }

		public Boolean Eliminado { get; set; }

		public CuentaContable ()
		{
			//FIX aca no debria inicializarse objetos
			Moneda = new Moneda ();
			TipoCuenta = new TipoDeCuentaContable ();
			Banco = new Banco ();
		}

		public override string ToString ()
		{
			return CodigoCuentaContable + " " + Cuenta;
		}

		public string Descripcion {
			get {
				return Cuenta;
			}
		}
	}
}
