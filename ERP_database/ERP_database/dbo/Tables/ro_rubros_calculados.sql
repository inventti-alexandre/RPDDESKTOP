﻿CREATE TABLE [dbo].[ro_rubros_calculados] (
    [IdEmpresa]               INT          NOT NULL,
    [IdRubro_dias_trabajados] VARCHAR (50) NOT NULL,
    [IdRubro_tot_ing]         VARCHAR (50) NOT NULL,
    [IdRubro_tot_egr]         VARCHAR (50) NOT NULL,
    [IdRubro_iess_perso]      VARCHAR (50) NOT NULL,
    [IdRubro_sueldo]          VARCHAR (50) NOT NULL,
    [IdRubro_tot_pagar]       VARCHAR (50) NOT NULL,
    [IdRubro_aporte_patronal] VARCHAR (50) NULL,
    [IdRubro_fondo_reserva]   VARCHAR (50) NULL,
    [IdRubro_prov_vac]        VARCHAR (50) NULL,
    [IdRubro_prov_DIII]       VARCHAR (50) NULL,
    [IdRubro_prov_DIV]        VARCHAR (50) NULL,
    [IdRubro_prov_FR]         VARCHAR (50) NULL,
    [IdRubro_DIII]            VARCHAR (50) NULL,
    [IdRubro_DIV]             VARCHAR (50) NULL,
    [IdRubro_IR]              VARCHAR (50) NULL,
    [IdRubro_FR]              VARCHAR (50) NULL,
    CONSTRAINT [PK_ro_rubros_calculados] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC),
    CONSTRAINT [FK_ro_rubros_calculados_ro_rubro_tipo] FOREIGN KEY ([IdEmpresa], [IdRubro_dias_trabajados]) REFERENCES [dbo].[ro_rubro_tipo] ([IdEmpresa], [IdRubro]),
    CONSTRAINT [FK_ro_rubros_calculados_ro_rubro_tipo1] FOREIGN KEY ([IdEmpresa], [IdRubro_tot_ing]) REFERENCES [dbo].[ro_rubro_tipo] ([IdEmpresa], [IdRubro]),
    CONSTRAINT [FK_ro_rubros_calculados_ro_rubro_tipo2] FOREIGN KEY ([IdEmpresa], [IdRubro_tot_egr]) REFERENCES [dbo].[ro_rubro_tipo] ([IdEmpresa], [IdRubro]),
    CONSTRAINT [FK_ro_rubros_calculados_ro_rubro_tipo3] FOREIGN KEY ([IdEmpresa], [IdRubro_iess_perso]) REFERENCES [dbo].[ro_rubro_tipo] ([IdEmpresa], [IdRubro]),
    CONSTRAINT [FK_ro_rubros_calculados_ro_rubro_tipo4] FOREIGN KEY ([IdEmpresa], [IdRubro_sueldo]) REFERENCES [dbo].[ro_rubro_tipo] ([IdEmpresa], [IdRubro]),
    CONSTRAINT [FK_ro_rubros_calculados_ro_rubro_tipo5] FOREIGN KEY ([IdEmpresa], [IdRubro_tot_pagar]) REFERENCES [dbo].[ro_rubro_tipo] ([IdEmpresa], [IdRubro])
);



