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
    
    public partial class spCXP_Rpt001_Result
    {
        public long IdRow { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Documento { get; set; }
        public string nom_tipo_doc { get; set; }
        public string cod_tipo_doc { get; set; }
        public Nullable<System.DateTime> co_fechaOg { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public double total { get; set; }
        public Nullable<double> valor { get; set; }
        public Nullable<double> Valor_debe { get; set; }
        public double Valor_Haber { get; set; }
        public Nullable<double> Saldo { get; set; }
        public string estado_pago { get; set; }
        public string Observacion { get; set; }
        public string Ruc_Proveedor { get; set; }
        public string representante_legal { get; set; }
        public string Tipo_cbte { get; set; }
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        public string cb_Observacion_pago { get; set; }
        public string tc_TipoCbte_pago { get; set; }
        public string cb_Cheque_pago { get; set; }
        public int IdClaseProveedor { get; set; }
        public string descripcion_clas_prove { get; set; }
        public int NUM_QUERRY { get; set; }
        public Nullable<bool> en_conciliacion { get; set; }
    }
}
