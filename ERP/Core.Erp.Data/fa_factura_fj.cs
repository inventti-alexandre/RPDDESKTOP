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
    
    public partial class fa_factura_fj
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string Atencion_a { get; set; }
        public string num_oc { get; set; }
        public string descripcion_fact { get; set; }
        public Nullable<System.DateTime> fecha_cobro_1 { get; set; }
        public Nullable<System.DateTime> fecha_cobro_2 { get; set; }
    }
}
