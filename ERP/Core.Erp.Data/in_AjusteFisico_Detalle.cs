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
    
    public partial class in_AjusteFisico_Detalle
    {
        public int IdEmpresa { get; set; }
        public decimal IdAjusteFisico { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double StockSistema { get; set; }
        public double CantidadAjustada { get; set; }
        public double StockFisico { get; set; }
        public string IdCentroCosto { get; set; }
    
        public virtual in_ajusteFisico in_ajusteFisico { get; set; }
        public virtual in_Producto in_Producto { get; set; }
    }
}
