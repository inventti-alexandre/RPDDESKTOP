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
    
    public partial class vwfa_liquidacion_x_punto_cargo_det_egresos_inventario
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int eg_secuencia { get; set; }
        public double eg_cantidad { get; set; }
        public double eg_precio_uni { get; set; }
        public double eg_por_ganancia { get; set; }
        public double eg_valor_ganancia { get; set; }
        public double eg_precio_total { get; set; }
        public Nullable<int> inv_IdEmpresa { get; set; }
        public Nullable<int> inv_IdSucursal { get; set; }
        public Nullable<int> inv_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> inv_IdNumMovi { get; set; }
        public Nullable<int> inv_Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_uni_medida { get; set; }
    }
}
