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
    
    public partial class fa_registro_unidades_x_equipo_det_ini_x_Af
    {
        public int IdEmpresa { get; set; }
        public decimal IdRegistro { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public Nullable<int> IdEmpresa_hn { get; set; }
        public Nullable<int> IdSucursal_hn { get; set; }
        public Nullable<int> IdBodega_hn { get; set; }
        public Nullable<decimal> IdCbteVta_hn { get; set; }
        public Nullable<int> IdEmpresa_he { get; set; }
        public Nullable<int> IdSucursal_he { get; set; }
        public Nullable<int> IdBodega_he { get; set; }
        public Nullable<decimal> IdCbteVta_he { get; set; }
    
        public virtual fa_registro_unidades_x_equipo fa_registro_unidades_x_equipo { get; set; }
    }
}
