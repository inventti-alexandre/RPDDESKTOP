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
    
    public partial class EntitiesProduccion_Cidersus : DbContext
    {
        public EntitiesProduccion_Cidersus()
            : base("name=EntitiesProduccion_Cidersus")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<prod_ChatarraTipo_CusTalme> prod_ChatarraTipo_CusTalme { get; set; }
        public DbSet<prod_Clave_Autorizacion> prod_Clave_Autorizacion { get; set; }
        public DbSet<prod_CompraChatarra_CusTalme> prod_CompraChatarra_CusTalme { get; set; }
        public DbSet<prod_CompraChatarra_CusTalme_x__in_movi_inven> prod_CompraChatarra_CusTalme_x__in_movi_inven { get; set; }
        public DbSet<prod_Costeo_in_movi_inve_data> prod_Costeo_in_movi_inve_data { get; set; }
        public DbSet<prod_Costeo_in_movi_inve_data_ProdTermi> prod_Costeo_in_movi_inve_data_ProdTermi { get; set; }
        public DbSet<prod_Costeo_in_movi_inve_data_SALDOINICIAL> prod_Costeo_in_movi_inve_data_SALDOINICIAL { get; set; }
        public DbSet<prod_Costeo_in_movi_inve_data_SALDOINICIAL_PROCTER> prod_Costeo_in_movi_inve_data_SALDOINICIAL_PROCTER { get; set; }
        public DbSet<prod_Costeo_ParametrosGenerales> prod_Costeo_ParametrosGenerales { get; set; }
        public DbSet<prod_Costeo_Rubros_Grupos> prod_Costeo_Rubros_Grupos { get; set; }
        public DbSet<prod_Costeo_Rubros_x_Tipo_costeo_cusTalme> prod_Costeo_Rubros_x_Tipo_costeo_cusTalme { get; set; }
        public DbSet<prod_Costeo_Rubros_x_Tipo_costeo_Datos_cusTalme> prod_Costeo_Rubros_x_Tipo_costeo_Datos_cusTalme { get; set; }
        public DbSet<prod_Costeo_Rubros_x_Tipo_costeo_Datos_cusTalme_Temp> prod_Costeo_Rubros_x_Tipo_costeo_Datos_cusTalme_Temp { get; set; }
        public DbSet<prod_Costeo_Rubros_x_tipo_costeo_Parametros_cusTalme> prod_Costeo_Rubros_x_tipo_costeo_Parametros_cusTalme { get; set; }
        public DbSet<prod_Costeo_Tipo_Costeo_cusTalme> prod_Costeo_Tipo_Costeo_cusTalme { get; set; }
        public DbSet<prod_GestionProductivaAcero_CusTalme> prod_GestionProductivaAcero_CusTalme { get; set; }
        public DbSet<prod_GestionProductivaAcero_CusTalme_x_in_movi_inven> prod_GestionProductivaAcero_CusTalme_x_in_movi_inven { get; set; }
        public DbSet<prod_GestionProductivaLaminado_CusTalme> prod_GestionProductivaLaminado_CusTalme { get; set; }
        public DbSet<prod_GestionProductivaLaminado_x_paradas_CusTalme> prod_GestionProductivaLaminado_x_paradas_CusTalme { get; set; }
        public DbSet<prod_GestionProductivaTechos_CusTalme_Cab> prod_GestionProductivaTechos_CusTalme_Cab { get; set; }
        public DbSet<prod_GestionProductivaTechos_CusTalme_Detalle> prod_GestionProductivaTechos_CusTalme_Detalle { get; set; }
        public DbSet<prod_GestionProductivaTechos_CusTalme_X_in_movi_inve> prod_GestionProductivaTechos_CusTalme_X_in_movi_inve { get; set; }
        public DbSet<prod_horno_CusTalme> prod_horno_CusTalme { get; set; }
        public DbSet<prod_LiquidacionChatarraDetalle> prod_LiquidacionChatarraDetalle { get; set; }
        public DbSet<prod_ModeloProduccion_CusTalme> prod_ModeloProduccion_CusTalme { get; set; }
        public DbSet<prod_ModeloProduccion_x_Producto_CusTal> prod_ModeloProduccion_x_Producto_CusTal { get; set; }
        public DbSet<prod_Operador> prod_Operador { get; set; }
        public DbSet<prod_Parametro> prod_Parametro { get; set; }
        public DbSet<prod_Parametros_x_MoviInven_x_ModeloProduccion> prod_Parametros_x_MoviInven_x_ModeloProduccion { get; set; }
        public DbSet<prod_ParametrosAceria> prod_ParametrosAceria { get; set; }
        public DbSet<prod_ParametrosPorCampos> prod_ParametrosPorCampos { get; set; }
        public DbSet<prod_ProgramaProd> prod_ProgramaProd { get; set; }
        public DbSet<prod_Proveedores_X_Presupuesto_CusTalme> prod_Proveedores_X_Presupuesto_CusTalme { get; set; }
        public DbSet<prod_PuenteGrua> prod_PuenteGrua { get; set; }
        public DbSet<prod_TipoParada_CusTalme> prod_TipoParada_CusTalme { get; set; }
        public DbSet<prod_Turno> prod_Turno { get; set; }
        public DbSet<ro_Acta_Finiquito> ro_Acta_Finiquito { get; set; }
        public DbSet<ro_Acta_Finiquito_Detalle> ro_Acta_Finiquito_Detalle { get; set; }
        public DbSet<ro_archivos_bancos_generacion> ro_archivos_bancos_generacion { get; set; }
        public DbSet<vwprd_CantidadEnsamblada_x_OT_CusCider> vwprd_CantidadEnsamblada_x_OT_CusCider { get; set; }
        public DbSet<vwprd_ControlProduccion_Obrero_Cab> vwprd_ControlProduccion_Obrero_Cab { get; set; }
        public DbSet<vwprd_ControlProduccion_Producto_x_Etapa> vwprd_ControlProduccion_Producto_x_Etapa { get; set; }
        public DbSet<vwprd_ControlProduccionObreroConsultaGeneral> vwprd_ControlProduccionObreroConsultaGeneral { get; set; }
        public DbSet<vwprd_ConversionDetalle_CusCidersus> vwprd_ConversionDetalle_CusCidersus { get; set; }
        public DbSet<vwprd_ConversionProCuscidersus> vwprd_ConversionProCuscidersus { get; set; }
        public DbSet<vwprd_Despacho> vwprd_Despacho { get; set; }
        public DbSet<vwprd_Ensamblado_CabDet_CusCider> vwprd_Ensamblado_CabDet_CusCider { get; set; }
        public DbSet<vwprd_Ensamblado_CusCidersus> vwprd_Ensamblado_CusCidersus { get; set; }
        public DbSet<vwprd_MovPteGrua> vwprd_MovPteGrua { get; set; }
        public DbSet<vwprd_ProcesoProductivo> vwprd_ProcesoProductivo { get; set; }
        public DbSet<vwprd_ProcesoProductivo_x_prd_obra> vwprd_ProcesoProductivo_x_prd_obra { get; set; }
        public DbSet<vwprd_Saldos_Requerimientos_x_OT> vwprd_Saldos_Requerimientos_x_OT { get; set; }
        public DbSet<vwprd_Saldos_x_Req_x_OT_x_Consumo> vwprd_Saldos_x_Req_x_OT_x_Consumo { get; set; }
        public DbSet<vwprd_SubgruposTrabajos> vwprd_SubgruposTrabajos { get; set; }
        public DbSet<vwprd_UsuarioAutorizados_Cidersus> vwprd_UsuarioAutorizados_Cidersus { get; set; }
        public DbSet<vwpre_PedidoXPresupuesto> vwpre_PedidoXPresupuesto { get; set; }
        public DbSet<vwpre_PedidoXPresupuesto_det> vwpre_PedidoXPresupuesto_det { get; set; }
        public DbSet<vwpre_presupuesto_plancta> vwpre_presupuesto_plancta { get; set; }
        public DbSet<vwPre_PresupuestoxCta> vwPre_PresupuestoxCta { get; set; }
        public DbSet<vwProd_CompraChatarra> vwProd_CompraChatarra { get; set; }
        public DbSet<vwProd_GestionProductivaAceria_CusTalme> vwProd_GestionProductivaAceria_CusTalme { get; set; }
        public DbSet<vwProd_GestionProductivaTalmeLaminado> vwProd_GestionProductivaTalmeLaminado { get; set; }
        public DbSet<vwprod_GestionProductivaTechos_Talme> vwprod_GestionProductivaTechos_Talme { get; set; }
        public DbSet<vwProd_ProgramaProd> vwProd_ProgramaProd { get; set; }
        public DbSet<vwProd_Rpt_GestionPordLaminados_Talme> vwProd_Rpt_GestionPordLaminados_Talme { get; set; }
        public DbSet<prd_ProcesoProductivo> prd_ProcesoProductivo { get; set; }
        public DbSet<prd_ProcesoProductivo_x_prd_obra> prd_ProcesoProductivo_x_prd_obra { get; set; }
        public DbSet<in_movi_inven_x_in_movi_inven_CusCidersus> in_movi_inven_x_in_movi_inven_CusCidersus { get; set; }
        public DbSet<vwin_GeneracionCompraCidersus> vwin_GeneracionCompraCidersus { get; set; }
        public DbSet<vwin_prd_CidersusConsultaProductosCortados> vwin_prd_CidersusConsultaProductosCortados { get; set; }
        public DbSet<vwin_ReimpresionCodigoBarra_cusCider> vwin_ReimpresionCodigoBarra_cusCider { get; set; }
        public DbSet<vwin_Producto_a_Cortar_CusCider> vwin_Producto_a_Cortar_CusCider { get; set; }
        public DbSet<prd_ControlInventarioProd> prd_ControlInventarioProd { get; set; }
        public DbSet<prd_ControlProduccion_Obrero> prd_ControlProduccion_Obrero { get; set; }
        public DbSet<prd_ControlProduccion_Obrero_Det> prd_ControlProduccion_Obrero_Det { get; set; }
        public DbSet<prd_ControlProduccion_Obrero_x_in_movi_inve> prd_ControlProduccion_Obrero_x_in_movi_inve { get; set; }
        public DbSet<prd_Conversion_CusCidersus> prd_Conversion_CusCidersus { get; set; }
        public DbSet<prd_conversion_cusCidersus_x_in_movi_inven> prd_conversion_cusCidersus_x_in_movi_inven { get; set; }
        public DbSet<prd_Conversion_det_CusCidersus> prd_Conversion_det_CusCidersus { get; set; }
        public DbSet<prd_Despacho> prd_Despacho { get; set; }
        public DbSet<prd_Despacho_cusCidersus_x_in_movi_inven> prd_Despacho_cusCidersus_x_in_movi_inven { get; set; }
        public DbSet<prd_DespachoDet> prd_DespachoDet { get; set; }
        public DbSet<prd_ensamblado_cusCider_x_in_movi_inven> prd_ensamblado_cusCider_x_in_movi_inven { get; set; }
        public DbSet<prd_Ensamblado_Det_CusCider> prd_Ensamblado_Det_CusCider { get; set; }
        public DbSet<prd_EtapaProduccion> prd_EtapaProduccion { get; set; }
        public DbSet<prd_GruposTrabajo> prd_GruposTrabajo { get; set; }
        public DbSet<prd_GruposTrabajo_PorPP> prd_GruposTrabajo_PorPP { get; set; }
        public DbSet<prd_GrupoTrabajo_Det> prd_GrupoTrabajo_Det { get; set; }
        public DbSet<prd_Obra> prd_Obra { get; set; }
        public DbSet<prd_PiezasEnEspera_Pendiente_PorSubgrupo> prd_PiezasEnEspera_Pendiente_PorSubgrupo { get; set; }
        public DbSet<prd_PteGrua> prd_PteGrua { get; set; }
        public DbSet<prd_UsuarioAutorizado_CusCider> prd_UsuarioAutorizado_CusCider { get; set; }
        public DbSet<vwin_movi_inve_detalle_x_Producto_x_OT_CusCider_Saldos> vwin_movi_inve_detalle_x_Producto_x_OT_CusCider_Saldos { get; set; }
        public DbSet<vwin_prd_ConsultaKardex> vwin_prd_ConsultaKardex { get; set; }
        public DbSet<vwin_prd_ConsultaPiezasMover> vwin_prd_ConsultaPiezasMover { get; set; }
        public DbSet<vwin_prd_EgresoInventario_x_Produccion> vwin_prd_EgresoInventario_x_Produccion { get; set; }
        public DbSet<vwin_prd_EtasProcesoProductivo> vwin_prd_EtasProcesoProductivo { get; set; }
        public DbSet<vwin_prd_GruposTrabajosPorPProductivos> vwin_prd_GruposTrabajosPorPProductivos { get; set; }
        public DbSet<vw_WSProduccionCidersus_Etapa_ProceP> vw_WSProduccionCidersus_Etapa_ProceP { get; set; }
        public DbSet<vw_WSProduccionCidersus_Loginmovil> vw_WSProduccionCidersus_Loginmovil { get; set; }
        public DbSet<vw_WSProduccionCidersus_OperadorPG> vw_WSProduccionCidersus_OperadorPG { get; set; }
        public DbSet<vw_WSProduccionCidersus_Trazabilidad> vw_WSProduccionCidersus_Trazabilidad { get; set; }
        public DbSet<vw_WSProduccionCidersus_Trazabilidad_IngresoEtapas> vw_WSProduccionCidersus_Trazabilidad_IngresoEtapas { get; set; }
        public DbSet<vw_WSProduccionCidersus_TrazabilidadPro> vw_WSProduccionCidersus_TrazabilidadPro { get; set; }
        public DbSet<vwPRO_CUS_CID_Rpt001> vwPRO_CUS_CID_Rpt001 { get; set; }
        public DbSet<prd_Orden_Taller> prd_Orden_Taller { get; set; }
        public DbSet<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos> vwin_movi_inve_detalle_x_Producto_CusCider_Saldos { get; set; }
        public DbSet<vwin_Imprimir_Cod_Barra> vwin_Imprimir_Cod_Barra { get; set; }
        public DbSet<vwin_Movi_Inven_Asig_Saldo_x_OT_CusCider> vwin_Movi_Inven_Asig_Saldo_x_OT_CusCider { get; set; }
        public DbSet<vwin_Movi_Inven_CusCider_Cab> vwin_Movi_Inven_CusCider_Cab { get; set; }
        public DbSet<vwin_Movi_Inven_x_CodBarra_CusCider> vwin_Movi_Inven_x_CodBarra_CusCider { get; set; }
        public DbSet<vwin_Movi_Inven_x_ControlProduccion_CusCider_Cab> vwin_Movi_Inven_x_ControlProduccion_CusCider_Cab { get; set; }
        public DbSet<vwin_Movi_Inven_x_Conversion_CusCider_Cab> vwin_Movi_Inven_x_Conversion_CusCider_Cab { get; set; }
        public DbSet<vwin_Movi_Inven_x_Ensamblado_CusCider_Cab> vwin_Movi_Inven_x_Ensamblado_CusCider_Cab { get; set; }
        public DbSet<vwprd_DespachoSaldo> vwprd_DespachoSaldo { get; set; }
        public DbSet<vwprd_OrdenCompraCidersus> vwprd_OrdenCompraCidersus { get; set; }
        public DbSet<prd_parametros_CusCidersus> prd_parametros_CusCidersus { get; set; }
        public DbSet<vwprd_OrdenTaller> vwprd_OrdenTaller { get; set; }
        public DbSet<vwin_ReimpresionCodigoBarraProductoTerminado_CusCider> vwin_ReimpresionCodigoBarraProductoTerminado_CusCider { get; set; }
        public DbSet<vw_WSProduccion_GruposTrabajo_PorPP> vw_WSProduccion_GruposTrabajo_PorPP { get; set; }
        public DbSet<vw_WSProduccionCidersus_EtapaSiguiente> vw_WSProduccionCidersus_EtapaSiguiente { get; set; }
        public DbSet<prd_Ensamblado_CusCider> prd_Ensamblado_CusCider { get; set; }
        public DbSet<prd_GrupoTrabajo> prd_GrupoTrabajo { get; set; }
        public DbSet<prd_Movimiento_PteGrua> prd_Movimiento_PteGrua { get; set; }
        public DbSet<vwprd_GrupoTrabajo_Det> vwprd_GrupoTrabajo_Det { get; set; }
        public DbSet<vwprd_GrupoTrabajo_x_Etapa> vwprd_GrupoTrabajo_x_Etapa { get; set; }
        public DbSet<vwprd_GrupoTrabajoEtapa> vwprd_GrupoTrabajoEtapa { get; set; }
        public DbSet<vwprd_Movimiento_PteGrua> vwprd_Movimiento_PteGrua { get; set; }
        public DbSet<vwprd_GrupoTrabajoCab> vwprd_GrupoTrabajoCab { get; set; }
        public DbSet<in_movi_inve_detalle_x_Producto_CusCider> in_movi_inve_detalle_x_Producto_CusCider { get; set; }
        public DbSet<vwprd_Obras_Cliente> vwprd_Obras_Cliente { get; set; }
    }
}
