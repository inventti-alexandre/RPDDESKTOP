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
    
    public partial class vwro_fectividad_x_empleado_Adm_x_periodo_Det
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_Tipo_Liq { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public Nullable<double> Meta { get; set; }
        public Nullable<double> Real { get; set; }
        public Nullable<double> Cumplimiento { get; set; }
        public Nullable<double> Variable_porcentaje_prorrateado { get; set; }
        public string cod_Pago_Variable { get; set; }
        public string nom_Pago_Variable { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_nombreCompleto { get; set; }
        public double Valor_bono { get; set; }
        public string ru_descripcion { get; set; }
    }
}
