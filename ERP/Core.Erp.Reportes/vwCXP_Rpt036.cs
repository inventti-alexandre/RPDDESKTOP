//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCXP_Rpt036
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public Nullable<System.DateTime> co_FechaContabilizacion { get; set; }
        public string co_factura { get; set; }
        public decimal IdProveedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string co_observacion { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public double Total_Retencion { get; set; }
        public double monto_pagado { get; set; }
        public double Saldo { get; set; }
        public Nullable<bool> origen_bodega { get; set; }
        public Nullable<bool> origen_caja { get; set; }
    }
}
