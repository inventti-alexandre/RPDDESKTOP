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
    
    public partial class spcp_Get_Data_orden_pago_con_Transferencia_data_Result
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public string IdTipo_op { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public decimal IdOrdenPago { get; set; }
        public int Secuencia_OP { get; set; }
        public string IdTipoPersona { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdEntidad { get; set; }
        public Nullable<System.DateTime> Fecha_OP { get; set; }
        public Nullable<System.DateTime> Fecha_Fa_Prov { get; set; }
        public Nullable<System.DateTime> Fecha_Venc_Fac_Prov { get; set; }
        public string Observacion { get; set; }
        public string Nom_Beneficiario { get; set; }
        public string Girar_Cheque_a { get; set; }
        public double Valor_a_pagar { get; set; }
        public double Valor_estimado_a_pagar_OP { get; set; }
        public double Total_cancelado_OP { get; set; }
        public double Saldo_x_Pagar_OP { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdFormaPago { get; set; }
        public Nullable<System.DateTime> Fecha_Pago { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdSubCentro_Costo { get; set; }
        public decimal Cbte_cxp { get; set; }
        public string Estado { get; set; }
        public string Nom_Beneficiario_2 { get; set; }
        public int IdEmpresa_cxp { get; set; }
        public int IdTipoCbte_cxp { get; set; }
        public decimal IdCbteCble_cxp { get; set; }
        public string IdTipoCta_acreditacion_cat { get; set; }
        public string num_cta_acreditacion { get; set; }
        public Nullable<int> IdBanco_acreditacion { get; set; }
        public string ba_descripcion { get; set; }
        public string CodigoLegal { get; set; }
        public string IdUsuario { get; set; }
        public bool Checked { get; set; }
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        public string tipo_cbte_pago { get; set; }
        public Nullable<decimal> Secuencial_reg_x_proceso { get; set; }
        public int Secuencia_ar { get; set; }
    }
}
