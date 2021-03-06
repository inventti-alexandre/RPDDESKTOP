﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesFacturacion : DbContext
    {
        public EntitiesFacturacion()
            : base("name=EntitiesFacturacion")
        {
        }
        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<fa_cliente_tipo> fa_cliente_tipo { get; set; }
        public DbSet<fa_devol_venta> fa_devol_venta { get; set; }
        public DbSet<fa_devol_venta_det> fa_devol_venta_det { get; set; }
        public DbSet<fa_factura_det_otros_campos> fa_factura_det_otros_campos { get; set; }
        public DbSet<fa_factura_x_ct_cbtecble> fa_factura_x_ct_cbtecble { get; set; }
        public DbSet<fa_factura_x_fa_guia_remision> fa_factura_x_fa_guia_remision { get; set; }
        public DbSet<fa_factura_x_in_movi_inve> fa_factura_x_in_movi_inve { get; set; }
        public DbSet<fa_factura_x_in_movi_inve_x_Anulacion> fa_factura_x_in_movi_inve_x_Anulacion { get; set; }
        public DbSet<fa_motivo_venta> fa_motivo_venta { get; set; }
        public DbSet<fa_notaCreDeb_x_ct_cbtecble> fa_notaCreDeb_x_ct_cbtecble { get; set; }
        public DbSet<fa_notaCreDeb_x_cxc_cobro> fa_notaCreDeb_x_cxc_cobro { get; set; }
        public DbSet<fa_TipoNota_x_Empresa_x_Sucursal> fa_TipoNota_x_Empresa_x_Sucursal { get; set; }
        public DbSet<fa_VendedorxSucursal> fa_VendedorxSucursal { get; set; }
        public DbSet<vwfa_Catalogo_IdAuto_numeric> vwfa_Catalogo_IdAuto_numeric { get; set; }
        public DbSet<vwfa_creditos_debitos_con_saldo> vwfa_creditos_debitos_con_saldo { get; set; }
        public DbSet<vwfa_devolucion> vwfa_devolucion { get; set; }
        public DbSet<vwfa_Documento_Tipo_x_Secuencia_Talonario> vwfa_Documento_Tipo_x_Secuencia_Talonario { get; set; }
        public DbSet<vwFa_Documentos_Relacionados_NC_ND> vwFa_Documentos_Relacionados_NC_ND { get; set; }
        public DbSet<vwFa_Documentos_x_Relacionar_NC_ND> vwFa_Documentos_x_Relacionar_NC_ND { get; set; }
        public DbSet<vwFa_TipoNota_x_Empresa> vwFa_TipoNota_x_Empresa { get; set; }
        public DbSet<vwFa_Ventas_x_cliente_x_periodo_BI> vwFa_Ventas_x_cliente_x_periodo_BI { get; set; }
        public DbSet<vwFa_Facturas_y_NotasDebito> vwFa_Facturas_y_NotasDebito { get; set; }
        public DbSet<vwfa_ContabilizacionFactura_x_Costo> vwfa_ContabilizacionFactura_x_Costo { get; set; }
        public DbSet<fa_factura_x_in_Ing_Egr_Inven> fa_factura_x_in_Ing_Egr_Inven { get; set; }
        public DbSet<fa_notaCreDeb_x_fa_factura_NotaDeb> fa_notaCreDeb_x_fa_factura_NotaDeb { get; set; }
        public DbSet<vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_NC> vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_NC { get; set; }
        public DbSet<vwfa_factura_x_cbte_cble> vwfa_factura_x_cbte_cble { get; set; }
        public DbSet<vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_cxc_cobro> vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_cxc_cobro { get; set; }
        public DbSet<vwfa_ContabilizacionFactura> vwfa_ContabilizacionFactura { get; set; }
        public DbSet<vwfa_ContabilizacionFactura_x_Sucursal> vwfa_ContabilizacionFactura_x_Sucursal { get; set; }
        public DbSet<vwFa_FacturasConDevolucionxItemConsulta> vwFa_FacturasConDevolucionxItemConsulta { get; set; }
        public DbSet<vwFa_FacturasConDevolucionxItemSaldos> vwFa_FacturasConDevolucionxItemSaldos { get; set; }
        public DbSet<vwFa_FacturasxDevolucionxIdDevolucion> vwFa_FacturasxDevolucionxIdDevolucion { get; set; }
        public DbSet<vwFa_FacturasxDevolucionxItem> vwFa_FacturasxDevolucionxItem { get; set; }
        public DbSet<vwfa_ContabilizarNotaCredDeb> vwfa_ContabilizarNotaCredDeb { get; set; }
        public DbSet<vwfa_ContabilizarNotaCredDeb_x_sucursal> vwfa_ContabilizarNotaCredDeb_x_sucursal { get; set; }
        public DbSet<fa_formaPago> fa_formaPago { get; set; }
        public DbSet<fa_factura_x_formaPago> fa_factura_x_formaPago { get; set; }
        public DbSet<fa_factura_x_fa_TerminoPago> fa_factura_x_fa_TerminoPago { get; set; }
        public DbSet<fa_TerminoPago> fa_TerminoPago { get; set; }
        public DbSet<fa_TerminoPago_Distribucion> fa_TerminoPago_Distribucion { get; set; }
        public DbSet<vwFa_Formas_Pago_x_Factura_DeclaracionSRI> vwFa_Formas_Pago_x_Factura_DeclaracionSRI { get; set; }
        public DbSet<vwFa_Documento_DeclaracionSRI> vwFa_Documento_DeclaracionSRI { get; set; }
        public DbSet<vwFa_Documento_DeclaracionSRI_DATA> vwFa_Documento_DeclaracionSRI_DATA { get; set; }
        public DbSet<fa_notaCreDeb> fa_notaCreDeb { get; set; }
        public DbSet<fa_PuntoVta> fa_PuntoVta { get; set; }
        public DbSet<vwfa_Nota_Credito> vwfa_Nota_Credito { get; set; }
        public DbSet<vwfa_factura_sri> vwfa_factura_sri { get; set; }
        public DbSet<fa_notaCreDeb_det> fa_notaCreDeb_det { get; set; }
        public DbSet<vwfa_notaCreDeb_det_sri> vwfa_notaCreDeb_det_sri { get; set; }
        public DbSet<vwfa_ContabilizarNotaCredDeb_x_Item> vwfa_ContabilizarNotaCredDeb_x_Item { get; set; }
        public DbSet<vwfa_notaCreDeb_sri> vwfa_notaCreDeb_sri { get; set; }
        public DbSet<fa_factura_det_x_fa_descuento> fa_factura_det_x_fa_descuento { get; set; }
        public DbSet<fa_descuento> fa_descuento { get; set; }
        public DbSet<vwfa_ContabilizacionFactura_x_descuento_x_item> vwfa_ContabilizacionFactura_x_descuento_x_item { get; set; }
        public DbSet<vwfa_factura_x_in_movi_inve> vwfa_factura_x_in_movi_inve { get; set; }
        public DbSet<vwfa_notaCreDeb> vwfa_notaCreDeb { get; set; }
        public DbSet<vwfa_movimientos_x_bodega_x_cat> vwfa_movimientos_x_bodega_x_cat { get; set; }
        public DbSet<fa_guia_remision_det> fa_guia_remision_det { get; set; }
        public DbSet<fa_guia_remision_det_x_factura> fa_guia_remision_det_x_factura { get; set; }
        public DbSet<vwfa_guia_remision_det> vwfa_guia_remision_det { get; set; }
        public DbSet<vwfa_factura_sin_guia> vwfa_factura_sin_guia { get; set; }
        public DbSet<vwfa_factura_con_guia> vwfa_factura_con_guia { get; set; }
        public DbSet<fa_proforma_det> fa_proforma_det { get; set; }
        public DbSet<fa_factura_det> fa_factura_det { get; set; }
        public DbSet<fa_guia_remision> fa_guia_remision { get; set; }
        public DbSet<vwfa_proforma_det_por_facturar> vwfa_proforma_det_por_facturar { get; set; }
        public DbSet<fa_proforma> fa_proforma { get; set; }
        public DbSet<vwfa_proforma> vwfa_proforma { get; set; }
        public DbSet<vwfa_Guia_Remision> vwfa_Guia_Remision { get; set; }
        public DbSet<fa_parametro> fa_parametro { get; set; }
        public DbSet<vwfa_ContabilizacionFactura_x_Item> vwfa_ContabilizacionFactura_x_Item { get; set; }
        public DbSet<fa_catalogo> fa_catalogo { get; set; }
        public DbSet<fa_catalogo_tipo> fa_catalogo_tipo { get; set; }
        public DbSet<fa_Vendedor> fa_Vendedor { get; set; }
        public DbSet<fa_vendedor_x_ro_empleado> fa_vendedor_x_ro_empleado { get; set; }
        public DbSet<fa_TipoNota> fa_TipoNota { get; set; }
        public DbSet<vwfa_cliente> vwfa_cliente { get; set; }
        public DbSet<vwfa_cliente_vista_previa> vwfa_cliente_vista_previa { get; set; }
        public DbSet<vwfa_PuntoVta> vwfa_PuntoVta { get; set; }
        public DbSet<fa_cuotas_x_doc> fa_cuotas_x_doc { get; set; }
        public DbSet<fa_factura> fa_factura { get; set; }
        public DbSet<fa_cliente> fa_cliente { get; set; }
        public DbSet<fa_cliente_contactos> fa_cliente_contactos { get; set; }
        public DbSet<vwfa_factura> vwfa_factura { get; set; }
        public DbSet<vwfa_factura_det> vwfa_factura_det { get; set; }
        public DbSet<vwfa_Factura_Dev> vwfa_Factura_Dev { get; set; }
    }
}
