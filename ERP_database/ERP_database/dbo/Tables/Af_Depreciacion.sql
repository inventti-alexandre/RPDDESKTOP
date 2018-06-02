﻿CREATE TABLE [dbo].[Af_Depreciacion] (
    [IdEmpresa]           INT           NOT NULL,
    [IdDepreciacion]      DECIMAL (18)  NOT NULL,
    [Cod_Depreciacion]    CHAR (20)     NULL,
    [IdPeriodo]           INT           NOT NULL,
    [Descripcion]         VARCHAR (200) NULL,
    [Fecha_Depreciacion]  DATETIME      NOT NULL,
    [Num_Act_Depre]       INT           NOT NULL,
    [Valor_Tot_Act]       FLOAT (53)    NOT NULL,
    [Valor_Tot_Depre]     FLOAT (53)    NOT NULL,
    [Valor_Tot_DepreAcum] FLOAT (53)    NOT NULL,
    [Valot_Tot_Importe]   FLOAT (53)    NOT NULL,
    [IdUsuario]           VARCHAR (20)  NULL,
    [Fecha_Transac]       DATETIME      NULL,
    [IdUsuarioUltMod]     VARCHAR (20)  NULL,
    [Fecha_UltMod]        DATETIME      NULL,
    [IdUsuarioUltAnu]     VARCHAR (20)  NULL,
    [Fecha_UltAnu]        DATETIME      NULL,
    [MotivoAnula]         VARCHAR (100) NULL,
    [Estado]              CHAR (1)      NOT NULL,
    CONSTRAINT [PK_Af_Depreciacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDepreciacion] ASC),
    CONSTRAINT [FK_Af_Depreciacion_ct_periodo] FOREIGN KEY ([IdEmpresa], [IdPeriodo]) REFERENCES [dbo].[ct_periodo] ([IdEmpresa], [IdPeriodo])
);

