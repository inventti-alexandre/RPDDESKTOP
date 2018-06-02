﻿CREATE TABLE [dbo].[Af_Retiro_Activo] (
    [IdEmpresa]        INT           NOT NULL,
    [IdRetiroActivo]   NUMERIC (18)  NOT NULL,
    [Cod_Ret_Activo]   CHAR (20)     NULL,
    [IdActivoFijo]     INT           NOT NULL,
    [ValorActivo]      FLOAT (53)    NOT NULL,
    [Valor_Tot_Bajas]  FLOAT (53)    NOT NULL,
    [Valor_Tot_Mejora] FLOAT (53)    NOT NULL,
    [Valor_Depre_Acu]  FLOAT (53)    NOT NULL,
    [Valor_Neto]       FLOAT (53)    NOT NULL,
    [NumComprobante]   VARCHAR (50)  NULL,
    [Concepto_Retiro]  VARCHAR (200) NULL,
    [Fecha_Retiro]     DATETIME      NOT NULL,
    [IdUsuario]        VARCHAR (20)  NULL,
    [Fecha_Transac]    DATETIME      NULL,
    [IdUsuarioUltMod]  VARCHAR (20)  NULL,
    [Fecha_UltMod]     DATETIME      NULL,
    [IdUsuarioUltAnu]  VARCHAR (20)  NULL,
    [Fecha_UltAnu]     DATETIME      NULL,
    [MotivoAnula]      VARCHAR (100) NULL,
    [nom_pc]           VARCHAR (50)  NULL,
    [ip]               VARCHAR (25)  NULL,
    [Estado]           CHAR (1)      NOT NULL,
    [IdEmpresa_ct]     INT           NULL,
    [IdTipoCbte]       INT           NULL,
    [IdCbteCble]       NUMERIC (18)  NULL,
    CONSTRAINT [PK_Af_Retiro_Activo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRetiroActivo] ASC),
    CONSTRAINT [FK_Af_Retiro_Activo_Af_Activo_fijo] FOREIGN KEY ([IdEmpresa], [IdActivoFijo]) REFERENCES [dbo].[Af_Activo_fijo] ([IdEmpresa], [IdActivoFijo]),
    CONSTRAINT [FK_Af_Retiro_Activo_ct_cbtecble] FOREIGN KEY ([IdEmpresa_ct], [IdTipoCbte], [IdCbteCble]) REFERENCES [dbo].[ct_cbtecble] ([IdEmpresa], [IdTipoCbte], [IdCbteCble])
);



