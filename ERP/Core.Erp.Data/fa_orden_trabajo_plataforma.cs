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
    
    public partial class fa_orden_trabajo_plataforma
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenTrabajo_Pla { get; set; }
        public string codOrdenTrabajo_Pla { get; set; }
        public decimal IdCliente { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public string serie { get; set; }
        public System.DateTime Fecha { get; set; }
        public double km_salida { get; set; }
        public double km_llegada { get; set; }
        public string con_atencion_a { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string vt_num_factura { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<decimal> IdTransportista { get; set; }
        public Nullable<int> IdVendedor { get; set; }
    }
}
