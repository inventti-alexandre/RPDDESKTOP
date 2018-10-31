﻿CREATE TABLE [dbo].[ct_centro_costo] (
    [IdEmpresa]          INT           NOT NULL,
    [IdCentroCosto]      VARCHAR (20)  NOT NULL,
    [CodCentroCosto]     VARCHAR (20)  NOT NULL,
    [Centro_costo]       VARCHAR (250) NOT NULL,
    [IdCentroCostoPadre] VARCHAR (20)  NULL,
    [IdCatalogo]         DECIMAL (10)  NULL,
    [pc_EsMovimiento]    CHAR (1)      NOT NULL,
    [IdNivel]            INT           NOT NULL,
    [pc_Estado]          CHAR (1)      NOT NULL,
    [IdCtaCble]          VARCHAR (20)  NULL,
    [Fecha_Transac]      DATETIME      NULL,
    [IdUsuario]          VARCHAR (50)  NULL,
    [IdUsuarioUltMod]    VARCHAR (50)  NULL,
    [Fecha_UltMod]       DATETIME      NULL,
    [IdUsuarioUltAnu]    VARCHAR (50)  NULL,
    [Fecha_UltAnu]       DATETIME      NULL,
    [MotivoAnulacion]    VARCHAR (150) NULL,
    [nom_pc]             VARCHAR (50)  NULL,
    [ip]                 VARCHAR (50)  NULL,
    CONSTRAINT [PK_ct_centro_costo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCentroCosto] ASC),
    CONSTRAINT [FK_ct_centro_costo_ct_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCostoPadre]) REFERENCES [dbo].[ct_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    
    CONSTRAINT [FK_ct_centro_costo_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble])
);

