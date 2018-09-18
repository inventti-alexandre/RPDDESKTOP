﻿CREATE VIEW dbo.vwRo_Solicitud_Vacaciones
AS
SELECT        dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa, dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitud, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.AnioServicio, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_q_Corresponde, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_pendiente, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Retorno, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Observacion, dbo.ro_Solicitud_Vacaciones_x_empleado.IdUsuario_Anu, dbo.ro_Solicitud_Vacaciones_x_empleado.Estado, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEstadoAprobacion, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado_aprue, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado_remp, dbo.ro_Solicitud_Vacaciones_x_empleado.Gozadas_Pgadas, dbo.ro_Solicitud_Vacaciones_x_empleado.Canceladas, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdVacacion, dbo.tb_persona.pe_cedulaRuc, dbo.ro_empleado.em_codigo
FROM            dbo.ro_Solicitud_Vacaciones_x_empleado INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
