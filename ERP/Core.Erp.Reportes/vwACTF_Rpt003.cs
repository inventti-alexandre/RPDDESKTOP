//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwACTF_Rpt003
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdActijoFijoTipo { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string Af_Codigo_Barra { get; set; }
        public string nom_tipo_depreciacion { get; set; }
        public string Af_Descripcion { get; set; }
        public string Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string Af_Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public string Af_Marca { get; set; }
        public string Af_Modelo { get; set; }
        public string Af_NumSerie { get; set; }
        public string Af_Color { get; set; }
        public string Af_Ubicacion { get; set; }
        public string NomCompleto { get; set; }
        public string Af_observacion { get; set; }
        public string Af_NumPlaca { get; set; }
        public Nullable<int> Af_Anio_fabrica { get; set; }
        public string Af_DescripcionCorta { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public double Af_costo_compra { get; set; }
        public double Af_Costo_historico { get; set; }
        public int Af_Vida_Util { get; set; }
        public int Af_Meses_depreciar { get; set; }
        public double Af_ValorSalvamento { get; set; }
        public double Af_ValorResidual { get; set; }
        public string Estado_Proceso { get; set; }
        public int IdPeriodoDeprec { get; set; }
        public string Descri_Periodo { get; set; }
        public double Valor_Depreciacion { get; set; }
        public double Valor_Depre_Acum { get; set; }
        public double Valor_Importe { get; set; }
    }
}
