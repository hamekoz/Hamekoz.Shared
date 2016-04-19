using System;
using Hamekoz.Core;
using Hamekoz.Fiscal;

namespace Hamekoz.Negocio
{
	public class RemitoClienteItem : IPersistible, IItem, IRemitoItem
	{
		//UNDONE Los valores deben calcularse solo si no esta grabado el remito, en caso contrario son lectura directa
		double porcentaje;

		public void SetPorcentaje (double porcentaje)
		{
			this.porcentaje = porcentaje;
		}

		public IRemito Remito {
			get;
			set;
		}

		public int Renglon {
			get;
			set;
		}

		public Articulo Articulo {
			get;
			set;
		}

		public decimal Cantidad {
			get;
			set;
		}

		public decimal Precio {
			get;
			set;
		}

		public decimal Total {
			get {
				return Math.Round (Precio * Cantidad, 2);
			}
		}

		public decimal Neto {
			get {
				return Math.Round (Articulo.Neto * Cantidad * (1 + (decimal)porcentaje / 100), 2);
			}
		}

		public decimal Impuestos {
			get {
				return Math.Round (Articulo.ImpuestosInternos * Cantidad * (1 + (decimal)porcentaje / 100), 2);
			}
		}

		public decimal IVA {
			get {
				return Math.Round (Articulo.IVA * Cantidad * (1 + (decimal)porcentaje / 100), 2);
			}
		}

		public decimal TasaIVA {
			get {
				return Articulo.TasaDeIVA;
			}
		}

		public Lote Lote {
			get;
			set;
		}

		public decimal Costo {
			get;
			set;
		}

		#region IItem

		string IItem.Descripcion {
			get {
				return Articulo.Nombre;
			}
		}

		string IItem.DescripcionCorta {
			get {
				return Articulo.NombreCorto;
			}
		}

		#endregion
	}
}
