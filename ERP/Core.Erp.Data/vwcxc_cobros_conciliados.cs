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
    
    public partial class vwcxc_cobros_conciliados
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public decimal IdConciliacion { get; set; }
        public string Tipo { get; set; }
        public Nullable<decimal> IdCobro { get; set; }
        public Nullable<decimal> IdNota { get; set; }
        public string CreDeb { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumNota_Impresa { get; set; }
        public Nullable<decimal> IdCliente { get; set; }
        public string NomSucursal { get; set; }
        public string Nom_Bodega { get; set; }
        public Nullable<System.DateTime> no_fecha { get; set; }
        public Nullable<System.DateTime> no_fecha_venc { get; set; }
        public string sc_observacion { get; set; }
        public string Nom_Cliente { get; set; }
        public string Motivo_Nota { get; set; }
        public string Referencia { get; set; }
        public double sc_total { get; set; }
        public double Saldo { get; set; }
        public string IdTipoConciliacion { get; set; }
        public string IdCobro_Tipo { get; set; }
        public Nullable<int> IdTipoNota { get; set; }
        public int IdCaja { get; set; }
    }
}
