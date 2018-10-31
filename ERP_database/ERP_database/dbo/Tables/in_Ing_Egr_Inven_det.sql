﻿CREATE TABLE [dbo].[in_Ing_Egr_Inven_det] (
    [IdEmpresa]                      INT             NOT NULL,
    [IdSucursal]                     INT             NOT NULL,
    [IdMovi_inven_tipo]              INT             NOT NULL,
    [IdNumMovi]                      NUMERIC (18)    NOT NULL,
    [Secuencia]                      INT             NOT NULL,
    [IdBodega]                       INT             NOT NULL,
    [IdProducto]                     NUMERIC (18)    NOT NULL,
    [dm_cantidad]                    FLOAT (53)      NOT NULL,
    [dm_observacion]                 NVARCHAR (1000) NULL,
    [mv_costo]                       FLOAT (53)      NOT NULL,
    [IdCentroCosto]                  VARCHAR (20)    NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20)    NULL,
    [IdEstadoAproba]                 VARCHAR (15)    NULL,
    [IdUnidadMedida]                 VARCHAR (25)    NOT NULL,
    [IdEmpresa_oc]                   INT             NULL,
    [IdSucursal_oc]                  INT             NULL,
    [IdOrdenCompra]                  NUMERIC (18)    NULL,
    [Secuencia_oc]                   INT             NULL,
    [IdPunto_cargo_grupo]            INT             NULL,
    [IdPunto_cargo]                  INT             NULL,
    [IdEmpresa_inv]                  INT             NULL,
    [IdSucursal_inv]                 INT             NULL,
    [IdBodega_inv]                   INT             NULL,
    [IdMovi_inven_tipo_inv]          INT             NULL,
    [IdNumMovi_inv]                  NUMERIC (18)    NULL,
    [secuencia_inv]                  INT             NULL,
    [Motivo_Aprobacion]              VARCHAR (200)   NULL,
    [dm_cantidad_sinConversion]      FLOAT (53)      NOT NULL,
    [IdUnidadMedida_sinConversion]   VARCHAR (25)    NOT NULL,
    [mv_costo_sinConversion]         FLOAT (53)      NULL,
    [IdMotivo_Inv]                   INT             NULL,
    CONSTRAINT [PK_in_Ing_Egr_Inven_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_com_ordencompra_local_det] FOREIGN KEY ([IdEmpresa_oc], [IdSucursal_oc], [IdOrdenCompra], [Secuencia_oc]) REFERENCES [dbo].[com_ordencompra_local_det] ([IdEmpresa], [IdSucursal], [IdOrdenCompra], [Secuencia]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_ct_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto]) REFERENCES [dbo].[ct_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_ct_centro_costo_sub_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]) REFERENCES [dbo].[ct_centro_costo_sub_centro_costo] ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_ct_punto_cargo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo]) REFERENCES [dbo].[ct_punto_cargo] ([IdEmpresa], [IdPunto_cargo]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdMovi_inven_tipo], [IdNumMovi]) REFERENCES [dbo].[in_Ing_Egr_Inven] ([IdEmpresa], [IdSucursal], [IdMovi_inven_tipo], [IdNumMovi]),
    
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_in_movi_inve_detalle] FOREIGN KEY ([IdEmpresa_inv], [IdSucursal_inv], [IdBodega_inv], [IdMovi_inven_tipo_inv], [IdNumMovi_inv], [secuencia_inv]) REFERENCES [dbo].[in_movi_inve_detalle] ([IdEmpresa], [IdSucursal], [IdBodega], [IdMovi_inven_tipo], [IdNumMovi], [Secuencia]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_in_UnidadMedida2] FOREIGN KEY ([IdUnidadMedida]) REFERENCES [dbo].[in_UnidadMedida] ([IdUnidadMedida]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_in_UnidadMedida3] FOREIGN KEY ([IdUnidadMedida_sinConversion]) REFERENCES [dbo].[in_UnidadMedida] ([IdUnidadMedida]),
    CONSTRAINT [FK_in_Ing_Egr_Inven_det_tb_bodega] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega]) REFERENCES [dbo].[tb_bodega] ([IdEmpresa], [IdSucursal], [IdBodega])
);

