﻿namespace Hamekoz.Negocio
{
    public class TipoContribuyenteIngresosBrutosEntity
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return "TipoContribuyenteIngresosBrutos: " + Id + " - descripcion" + Descripcion;
        }
    }
}
