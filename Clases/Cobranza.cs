using System;
using Hamekoz.Core;

namespace Hamekoz.Negocio
{
	public class Cobranza : IPersistible, IIdentifiable
	{
		public int Id { 
			get;
			set;
		}

		//UNDONE revisar que siempre sea contra una factura de cliente
		public FacturaCliente Comprobante { 
			get; 
			set;
		}

		public Recibo Recibo { 
			get;
			set;
		}

		//UNDONE revisar el nombre de esta propeuidad
		public decimal MontoImputado { 
			get;
			set;
		}

		public DateTime Fecha { 
			get;
			set;
		}

		public bool Eliminado { 
			get;
			set;
		}
	}
}
