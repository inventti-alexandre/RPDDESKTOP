//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwprd_DespachoSaldo
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdEnsamblado { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public decimal IdGrupoTrabajo { get; set; }
        public decimal IdProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> FechaAnu { get; set; }
        public System.DateTime FechaTransac { get; set; }
        public Nullable<System.DateTime> FechaUltModi { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_observacion { get; set; }
        public double pr_precio_publico { get; set; }
        public double pr_precio_mayor { get; set; }
        public double pr_precio_minimo { get; set; }
        public double pr_precio_puerta { get; set; }
        public int pr_stock { get; set; }
        public string pr_descripcion_2 { get; set; }
    }
}
