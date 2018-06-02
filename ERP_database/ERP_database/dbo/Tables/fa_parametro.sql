﻿CREATE TABLE [dbo].[fa_parametro] (
    [IdEmpresa]                                INT             NOT NULL,
    [IdMovi_inven_tipo_Factura]                INT             NULL,
    [pa_porc_max_total_item_x_despa_Guia]      FLOAT (53)      NULL,
    [IdMovi_inven_tipo_Dev_Vta]                INT             NULL,
    [IdMovi_inven_tipo_Factura_Anulacion]      INT             NULL,
    [IdMovi_inven_tipo_Dev_Vta_Anulacion]      INT             NULL,
    [Tipo_NC_x_DevVta]                         INT             NULL,
    [IdDepartamento_x_DevVta]                  INT             NULL,
    [IdTipoCbteCble_Factura]                   INT             NULL,
    [IdTipoCbteCble_Factura_Reverso]           INT             NULL,
    [IdTipoCbteCble_Factura_Costo_VTA]         INT             NULL,
    [IdTipoCbteCble_Factura_Costo_VTA_Reverso] INT             NULL,
    [IdTipoCbteCble_NC]                        INT             NULL,
    [IdTipoCbteCble_NC_Reverso]                INT             NULL,
    [IdTipoCbteCble_ND]                        INT             NULL,
    [IdTipoCbteCble_ND_Reverso]                INT             NULL,
    [SeImprimiGuiaRemiAuto]                    CHAR (1)        NULL,
    [NumeroDeItemFact]                         INT             NULL,
    [TipoCobroDafaultFactu]                    VARCHAR (20)    NULL,
    [IdCaja_Default_Factura]                   INT             NULL,
    [IdCtaCble_x_anticipo_cliente]             VARCHAR (20)    NULL,
    [pa_IdTipoNota_NC_x_Anulacion]             INT             NULL,
    [pa_ruta_descarga_xml_fac_elct]            VARCHAR (500)   NULL,
    [File_Reporte_FacturaDiseño]               VARBINARY (MAX) NULL,
    [File_Reporte_Nota_CRED_DEB]               VARBINARY (MAX) NULL,
    [IdCtaCble_IVA]                            VARCHAR (20)    NULL,
    [IdCtaCble_SubTotal_Vtas_x_Default]        VARCHAR (20)    NULL,
    [IdCtaCble_CXC_Vtas_x_Default]             VARCHAR (20)    NULL,
    [pa_X_Defecto_la_factura_es_cbte_elect]    BIT             NULL,
    [pa_X_Defecto_la_guia_es_cbte_elect]       BIT             NULL,
    [pa_X_Defecto_la_ND_es_cbte_elect]         BIT             NULL,
    [pa_X_Defecto_la_NC_es_cbte_elect]         BIT             NULL,
    [pa_Contabiliza_descuento]                 BIT             NULL,
    [pa_IdCtaCble_descuento]                   VARCHAR (20)    NULL,
    [NumeroDeItemProforma]                     INT             NULL,
    [clave_desbloqueo_precios]                 VARCHAR (200)   NULL,
    CONSTRAINT [PK_fa_parametro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC),
    CONSTRAINT [FK_fa_parametro_caj_Caja] FOREIGN KEY ([IdEmpresa], [IdCaja_Default_Factura]) REFERENCES [dbo].[caj_Caja] ([IdEmpresa], [IdCaja]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_Factura]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo1] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_Factura_Reverso]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo2] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_Factura_Costo_VTA]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo3] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_Factura_Costo_VTA_Reverso]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo4] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_NC]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo5] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_NC_Reverso]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo6] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_ND]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_cbtecble_tipo7] FOREIGN KEY ([IdEmpresa], [IdTipoCbteCble_ND_Reverso]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_fa_parametro_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble_x_anticipo_cliente]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_fa_parametro_ct_plancta1] FOREIGN KEY ([IdEmpresa], [IdCtaCble_IVA]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_fa_parametro_ct_plancta2] FOREIGN KEY ([IdEmpresa], [pa_IdCtaCble_descuento]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_fa_parametro_cxc_cobro_tipo] FOREIGN KEY ([TipoCobroDafaultFactu]) REFERENCES [dbo].[cxc_cobro_tipo] ([IdCobro_tipo]),
    CONSTRAINT [FK_fa_parametro_fa_TipoNota] FOREIGN KEY ([pa_IdTipoNota_NC_x_Anulacion]) REFERENCES [dbo].[fa_TipoNota] ([IdTipoNota]),
    CONSTRAINT [FK_fa_parametro_in_movi_inven_tipo] FOREIGN KEY ([IdDepartamento_x_DevVta], [IdMovi_inven_tipo_Factura]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_fa_parametro_in_movi_inven_tipo1] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_Dev_Vta]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_fa_parametro_in_movi_inven_tipo2] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_Factura_Anulacion]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_fa_parametro_in_movi_inven_tipo3] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_Dev_Vta_Anulacion]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_fa_parametro_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);





