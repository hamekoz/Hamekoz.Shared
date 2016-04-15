using System;

namespace Hamekoz.Negocio
{
	public class BancoEntity
	{
		public int Id { get; set; }

		public string Descripcion { get; set; }

		public int Clearing{ get; set; }

		public string CUIT { get; set; }

		public Boolean Eliminado { get; set; }

		//RELACIONES
		//El id dela cuenta contable no esta en la tabla banco sino que en cuentacontable se encuentra el id del banco
		//pongo la relacion aqui por comodidad, es cargada en el negocio de banco
		public CuentaContableEntity CuentaContable { get; set; }

		public override string ToString ()
		{
			return "BancoEntity: " + Id + " - descripcion" + Descripcion;
		}
	}
}
