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
    
    public partial class cxc_cancelacion_Intercompany
    {
        public cxc_cancelacion_Intercompany()
        {
            this.cxc_cancelacion_Intercompany_det = new HashSet<cxc_cancelacion_Intercompany_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdCancelacion { get; set; }
        public decimal IdCliente { get; set; }
        public string IdCobro_tipo { get; set; }
        public Nullable<int> IdBanco_Deposito { get; set; }
        public string Observacion { get; set; }
        public string PapeletaDeposito { get; set; }
        public Nullable<int> cbteban_IdEmpresa { get; set; }
        public Nullable<decimal> cbteban_IdCbteCble { get; set; }
        public Nullable<int> cbteban_IdTipocbte { get; set; }
        public Nullable<double> cr_TotalCobro { get; set; }
        public Nullable<System.DateTime> cr_fecha { get; set; }
        public Nullable<System.DateTime> cr_fechaDocu { get; set; }
        public Nullable<System.DateTime> cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string cr_Tarjeta { get; set; }
        public string cr_propietarioCta { get; set; }
        public string cr_estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public int IdSucursal { get; set; }
        public string GeneraDeps { get; set; }
        public int IdCaja { get; set; }
        public string IdTipoNotaCredito { get; set; }
    
        public virtual ICollection<cxc_cancelacion_Intercompany_det> cxc_cancelacion_Intercompany_det { get; set; }
        public virtual cxc_cobro_tipo cxc_cobro_tipo { get; set; }
    }
}
