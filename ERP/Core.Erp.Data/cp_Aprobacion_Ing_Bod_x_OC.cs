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
    
    public partial class cp_Aprobacion_Ing_Bod_x_OC
    {
        public cp_Aprobacion_Ing_Bod_x_OC()
        {
            this.cp_Conciliacion_Ing_Bodega_x_Orden_Giro = new HashSet<cp_Conciliacion_Ing_Bodega_x_Orden_Giro>();
            this.cp_Aprobacion_Ing_Bod_x_OC_det = new HashSet<cp_Aprobacion_Ing_Bod_x_OC_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public System.DateTime Fecha_aprobacion { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public int IdIden_credito { get; set; }
        public decimal IdProveedor { get; set; }
        public string Observacion { get; set; }
        public string Serie { get; set; }
        public string Serie2 { get; set; }
        public string num_documento { get; set; }
        public string num_auto_Proveedor { get; set; }
        public string num_auto_Imprenta { get; set; }
        public System.DateTime Fecha_Factura { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double Descuento { get; set; }
        public double co_baseImponible { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public int co_plazo { get; set; }
        public Nullable<System.DateTime> co_FechaVctoAutorizacion { get; set; }
        public Nullable<int> IdTipoMovi { get; set; }
    
        public virtual cp_orden_giro cp_orden_giro { get; set; }
        public virtual ICollection<cp_Conciliacion_Ing_Bodega_x_Orden_Giro> cp_Conciliacion_Ing_Bodega_x_Orden_Giro { get; set; }
        public virtual ICollection<cp_Aprobacion_Ing_Bod_x_OC_det> cp_Aprobacion_Ing_Bod_x_OC_det { get; set; }
        public virtual cp_proveedor cp_proveedor { get; set; }
    }
}
