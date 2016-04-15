using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	//TODO: Falta agregar CuentasBase
	public class CuentaContableEntity : IDescriptible
	{
		public int Id { get; set; }

		public int IdCuentaContableSuma { get; set; }

		public int IdCuentaBase { get; set; }

		public string Cuenta { get; set; }

		public Boolean RecibeAsientos { get; set; }

		public double Saldo { get; set; }

		public double SaldoDiferido { get; set; }

		public MonedaEntity Moneda { get; set; }

		public TipoCuentaContableEntity TipoCuenta { get; set; }
		// SIN DATO / EFECTIVO / CHEQUE
		public Boolean Modificable { get; set; }

		public BancoEntity Banco { get; set; }

		public int CodigoCuentaContable{ get; set; }

		public int Tabulacion { get; set; }

		public Boolean Eliminado { get; set; }

		public CuentaContableEntity ()
		{
			//FIX aca no debria inicializarse objetos
			Moneda = new MonedaEntity ();
			TipoCuenta = new TipoCuentaContableEntity ();
			Banco = new BancoEntity ();
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
