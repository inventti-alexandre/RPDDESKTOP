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
    
    public partial class vwcxc_conciliacion_Det_Anticipo
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdConciliacion { get; set; }
        public Nullable<decimal> IdCobro { get; set; }
        public Nullable<decimal> IdCobro_cobro { get; set; }
        public decimal IdAnticipo { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Observacion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string IdCobro_tipo { get; set; }
        public string cr_Banco { get; set; }
        public string cr_NumDocumento { get; set; }
        public int IdCaja { get; set; }
        public double cr_TotalCobro { get; set; }
        public double Saldo_Pendiente { get; set; }
        public string IdTipoConciliacion { get; set; }
        public Nullable<decimal> IdCliente { get; set; }
    }
}
