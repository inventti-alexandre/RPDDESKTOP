﻿CREATE TABLE [dbo].[in_devolucion_inven] (
    [IdEmpresa]             INT            NOT NULL,
    [IdDev_Inven]           NUMERIC (18)   NOT NULL,
    [cod_Dev_Inven]         VARCHAR (50)   NULL,
    [Fecha]                 DATETIME       NOT NULL,
    [dev_IdEmpresa]         INT            NOT NULL,
    [dev_IdSucursal]        INT            NOT NULL,
    [dev_IdMovi_inven_tipo] INT            NOT NULL,
    [dev_IdNumMovi]         NUMERIC (18)   NOT NULL,
    [observacion]           VARCHAR (2000) NULL,
    [Estado]                BIT            NOT NULL,
    [IdUsuario]             VARCHAR (50)   NULL,
    [Fecha_Transac]         DATETIME       NULL,
    [IdUsuarioUltModi]      VARCHAR (50)   NULL,
    [Fecha_UltMod]          DATETIME       NULL,
    [IdusuarioUltAnu]       VARCHAR (50)   NULL,
    [Fecha_UltAnu]          DATETIME       NULL,
    [MotivoAnulacion]       VARCHAR (3000) NULL,
    CONSTRAINT [PK_in_devolucion_inven] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDev_Inven] ASC),
    CONSTRAINT [FK_in_devolucion_inven_in_Ing_Egr_Inven] FOREIGN KEY ([dev_IdEmpresa], [dev_IdSucursal], [dev_IdMovi_inven_tipo], [dev_IdNumMovi]) REFERENCES [dbo].[in_Ing_Egr_Inven] ([IdEmpresa], [IdSucursal], [IdMovi_inven_tipo], [IdNumMovi])
);



