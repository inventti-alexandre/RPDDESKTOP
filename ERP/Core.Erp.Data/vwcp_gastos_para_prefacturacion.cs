//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcp_gastos_para_prefacturacion
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public string co_factura { get; set; }
        public string co_observacion { get; set; }
        public double co_total { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<double> subtotal_sin_iva { get; set; }
        public double co_Por_iva { get; set; }
        public Nullable<double> valor_iva { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public Nullable<double> Total { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string pe_nombreCompleto { get; set; }
    }
}
