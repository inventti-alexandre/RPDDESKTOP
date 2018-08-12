﻿CREATE VIEW dbo.vwimp_orden_compra_ext_ct_cbteble_det_gastos
AS
SELECT        dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdEmpresa, dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdOrdenCompra_ext, dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdEmpresa_ct, 
                         dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdTipoCbte, dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdCbteCble, dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.secuencia_ct, 
                         dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdGasto_tipo, dbo.ct_cbtecble_det.dc_Valor, dbo.ct_plancta.pc_Cuenta, dbo.ct_cbtecble_det.dc_Observacion, dbo.ct_cbtecble_det.IdCtaCble
FROM            dbo.ct_cbtecble_det INNER JOIN
                         dbo.imp_orden_compra_ext_ct_cbteble_det_gastos ON dbo.ct_cbtecble_det.IdEmpresa = dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdEmpresa_ct AND 
                         dbo.ct_cbtecble_det.IdTipoCbte = dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdTipoCbte AND dbo.ct_cbtecble_det.IdCbteCble = dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.IdCbteCble AND 
                         dbo.ct_cbtecble_det.secuencia = dbo.imp_orden_compra_ext_ct_cbteble_det_gastos.secuencia_ct INNER JOIN
                         dbo.ct_plancta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ct_plancta.IdCtaCble
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[64] 4[5] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ct_cbtecble_det"
            Begin Extent = 
               Top = 10
               Left = 405
               Bottom = 316
               Right = 668
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "imp_orden_compra_ext_ct_cbteble_det_gastos"
            Begin Extent = 
               Top = 23
               Left = 0
               Bottom = 333
               Right = 330
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 10
               Left = 696
               Bottom = 344
               Right = 879
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwimp_orden_compra_ext_ct_cbteble_det_gastos';




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwimp_orden_compra_ext_ct_cbteble_det_gastos';

