using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	//FIX renombrar en singular
	public class MovimientoDeArticulos : IPersistible, IIdentifiable
	{
		public int Id {
			get;
			set;
		}

		public TipoDeMovimiento Tipo {
			get;
			set;
		}

		public DateTime Fecha {
			get;
			set;
		}

		public Articulo Articulo {
			get;
			set;
		}

		public Lote Lote {
			get;
			set;
		}

		public double Cantidad {
			get;
			set;
		}

		public Deposito Origen {
			get;
			set;
		}

		public Deposito Destino {
			get;
			set;
		}

		public string Comentarios {
			get;
			set;
		}
	}
}
