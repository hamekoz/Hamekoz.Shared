using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Banco : IPersistible, IIdentifiable, IDescriptible
	{
		public int Id {
			get;
			set;
		}

		public string Nombre {
			get;
			set;
		}

		public string CUIT {
			get;
			set;
		}

		public int Clearing {
			get;
			set;
		}

		public bool Eliminado {
			get;
			set;
		}

		//HACK la cuenta contable deberia estar en una relacion entre el banco y la cuenta
		//El id dela cuenta contable no esta en la tabla banco sino que en cuentacontable se encuentra el id del banco
		//pongo la relacion aqui por comodidad, es cargada en el negocio de banco
		public CuentaContable CuentaContable {
			get;
			set;
		}

		string IDescriptible.Descripcion {
			get {
				return Nombre;
			}
		}
	}
}
