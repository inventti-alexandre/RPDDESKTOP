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
    
    public partial class vwCXP_Rpt029
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public string pr_codigo { get; set; }
        public string pr_nombre { get; set; }
        public string Factura { get; set; }
        public string NumRetencion { get; set; }
        public Nullable<double> co_Por_iva { get; set; }
        public Nullable<double> co_valoriva { get; set; }
        public Nullable<double> co_subtotal_iva { get; set; }
        public Nullable<double> co_subtotal_siniva { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<double> Base_Fuente { get; set; }
        public Nullable<double> Diferencia { get; set; }
        public string Tiene_retencion { get; set; }
        public string re_tipoRet { get; set; }
    }
}
