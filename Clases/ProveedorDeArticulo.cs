using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	[Obsolete ("Usar clase ProveedorDeArticulo")]
	public class ProveedorArticulo : ProveedorDeArticulo
	{

	}

	public class ProveedorDeArticulo : IPersistible, IIdentifiable
	{
		public ProveedorDeArticulo ()
		{
			//HACK no deberia inicializarse el objeto en el constructor
			Proveedor = new Proveedor ();
			Articulo = new Articulo ();
			Nombre = string.Empty;
		}

		#region IIdentifiable implementation

		public int Id {
			get;
			set;
		}

		#endregion

		/// <summary>
		/// Gets or sets the codigo.
		/// </summary>
		/// <value>Codigo segun el proveedor.</value>
		public string Codigo {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the nombre.
		/// </summary>
		/// <value>Nombre segun el proveedor.</value>
		public string Nombre {
			get;
			set;
		}

		public decimal Precio {
			get;
			set;
		}

		public DateTime UltimaCompra {
			get;
			set;
		} = DateTime.Now.Date;

		public Articulo Articulo {
			get;
			set;
		}

		public Proveedor Proveedor {
			get;
			set;
		}
	}
}
