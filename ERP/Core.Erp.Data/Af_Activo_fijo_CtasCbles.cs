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
    
    public partial class Af_Activo_fijo_CtasCbles
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdTipoCuenta { get; set; }
        public int Secuencia { get; set; }
        public double porc_distribucion { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string Observacion { get; set; }
    
        public virtual Af_Activo_fijo_CtasCbles_Tipo Af_Activo_fijo_CtasCbles_Tipo { get; set; }
        public virtual Af_Activo_fijo Af_Activo_fijo { get; set; }
    }
}
