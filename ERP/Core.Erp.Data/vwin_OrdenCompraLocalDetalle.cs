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
    
    public partial class vwin_OrdenCompraLocalDetalle
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public string IdCentroCosto { get; set; }
        public int IdOrdenTaller { get; set; }
        public decimal IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_costo { get; set; }
        public double do_porc_des { get; set; }
        public double do_descuento { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public string do_ManejaIva { get; set; }
        public string do_Costeado { get; set; }
        public double do_costo_promedio_hist { get; set; }
        public double do_peso { get; set; }
        public string do_observacion { get; set; }
        public string CodCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public int NumeroOT { get; set; }
        public string CodOdenTaller { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
    }
}
