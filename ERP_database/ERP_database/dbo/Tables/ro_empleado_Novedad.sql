﻿CREATE TABLE [dbo].[ro_empleado_Novedad] (
    [IdEmpresa]          INT           NOT NULL,
    [IdNovedad]          NUMERIC (18)  NOT NULL,
    [IdEmpleado]         NUMERIC (18)  NOT NULL,
    [IdNomina_Tipo]      INT           NOT NULL,
    [IdNomina_TipoLiqui] INT           NOT NULL,
    [Fecha]              DATETIME      NOT NULL,
    [TotalValor]         FLOAT (53)    NOT NULL,
    [Fecha_PrimerPago]   DATETIME      NULL,
    [NumCoutas]          INT           NULL,
    [IdUsuario]          VARCHAR (20)  NOT NULL,
    [Fecha_Transac]      DATETIME      NOT NULL,
    [IdUsuarioUltMod]    VARCHAR (20)  NULL,
    [Fecha_UltMod]       DATETIME      NULL,
    [IdUsuarioUltAnu]    VARCHAR (20)  NULL,
    [Fecha_UltAnu]       DATETIME      NULL,
    [nom_pc]             VARCHAR (50)  NULL,
    [ip]                 VARCHAR (25)  NULL,
    [MotiAnula]          VARCHAR (200) NULL,
    [Estado]             CHAR (1)      NOT NULL,
    [IdCentroCosto]      VARCHAR (20)  NULL,
    [MotivoModiica]      VARCHAR (100) NULL,
    [IdCalendario]       VARCHAR (10)  NULL,
    [IdPeriodo]          INT           NULL,
    [Observacion]        VARCHAR (500) NULL,
    CONSTRAINT [PK_ro_Empleado_Novedad_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNovedad] ASC, [IdEmpleado] ASC),
    CONSTRAINT [FK_ro_empleado_Novedad_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_empleado_Novedad_ro_Nomina_Tipoliqui] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui]) REFERENCES [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui])
);



