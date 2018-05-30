﻿CREATE TABLE [dbo].[ro_prestamo] (
    [IdEmpresa]          INT           NOT NULL,
    [IdPrestamo]         NUMERIC (18)  NOT NULL,
    [IdEmpleado]         NUMERIC (18)  NOT NULL,
    [IdRubro]            VARCHAR (50)  NOT NULL,
    [IdEmpleado_Aprueba] NUMERIC (18)  NOT NULL,
    [descuento_mensual]  BIT           NOT NULL,
    [descuento_quincena] BIT           NOT NULL,
    [descuento_men_quin] BIT           NOT NULL,
    [Estado]             CHAR (1)      NOT NULL,
    [Fecha]              DATETIME      NOT NULL,
    [MontoSol]           FLOAT (53)    NOT NULL,
    [TasaInteres]        FLOAT (53)    NOT NULL,
    [TotalPrestamo]      FLOAT (53)    NOT NULL,
    [NumCuotas]          INT           NOT NULL,
    [Fecha_PriPago]      DATETIME      NOT NULL,
    [Observacion]        VARCHAR (250) NOT NULL,
    [Tipo_Calculo]       VARCHAR (1)   NULL,
    [IdUsuario]          VARCHAR (20)  NOT NULL,
    [Fecha_Transac]      DATETIME      NOT NULL,
    [IdUsuarioUltMod]    VARCHAR (20)  NULL,
    [Fecha_UltMod]       DATETIME      NULL,
    [IdUsuarioUltAnu]    VARCHAR (20)  NULL,
    [Fecha_UltAnu]       DATETIME      NULL,
    [nom_pc]             VARCHAR (50)  NULL,
    [ip]                 VARCHAR (25)  NULL,
    [MotiAnula]          VARCHAR (200) NULL,
    [IdTipoCbte]         INT           NULL,
    [IdCbteCble]         NUMERIC (9)   NULL,
    [IdOrdenPago]        NUMERIC (9)   NULL,
    CONSTRAINT [PK_ro_prestamo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPrestamo] ASC),
    CONSTRAINT [FK_ro_prestamo_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado])
);





