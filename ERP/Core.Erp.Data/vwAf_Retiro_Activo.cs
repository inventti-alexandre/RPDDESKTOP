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
    
    public partial class vwAf_Retiro_Activo
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetiroActivo { get; set; }
        public string Cod_Ret_Activo { get; set; }
        public int IdActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public string NomCompleto { get; set; }
        public double ValorActivo { get; set; }
        public double Valor_Tot_Bajas { get; set; }
        public double Valor_Tot_Mejora { get; set; }
        public double Valor_Depre_Acu { get; set; }
        public double Valor_Neto { get; set; }
        public string NumComprobante { get; set; }
        public string Concepto_Retiro { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha_Retiro { get; set; }
    }
}
