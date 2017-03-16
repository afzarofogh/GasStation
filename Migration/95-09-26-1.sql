USE [GasStation]
GO

/****** Object:  View [dbo].[viewCustomer]    Script Date: 17/12/2016 05:15:02 È.Ù ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[viewCustomer]
AS
SELECT dbo.Owner.id, dbo.Owner.viewId, dbo.Owner.nationalCode, dbo.Owner.name, dbo.Owner.lastname, dbo.Owner.mobile, dbo.Plate.plate, dbo.[Base.PlateCity].city, dbo.[Base.PlateType].type, dbo.[Base.CarSystem].system, 
                  dbo.[Base.CarLevel].levelcar, dbo.[Base.CarColor].color, dbo.[Base.CarType].type AS typeCar
FROM     dbo.[Base.CarLevel] INNER JOIN
                  dbo.Plate INNER JOIN
                  dbo.Car ON dbo.Plate.id = dbo.Car.plateId INNER JOIN
                  dbo.[Base.PlateType] ON dbo.Plate.plateTypeId = dbo.[Base.PlateType].id INNER JOIN
                  dbo.[Base.PlateCity] ON dbo.Plate.plateCityId = dbo.[Base.PlateCity].id INNER JOIN
                  dbo.[Base.CarType] ON dbo.Car.carTypeId = dbo.[Base.CarType].id INNER JOIN
                  dbo.[Base.CarSystem] ON dbo.Car.carSystemId = dbo.[Base.CarSystem].id ON dbo.[Base.CarLevel].id = dbo.Car.carLevelId INNER JOIN
                  dbo.[Base.CarColor] ON dbo.Car.carColorId = dbo.[Base.CarColor].id INNER JOIN
                  dbo.CarOwner ON dbo.Car.id = dbo.CarOwner.carId INNER JOIN
                  dbo.Owner ON dbo.CarOwner.ownerId = dbo.Owner.id

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[12] 2[6] 3) )"
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
         Begin Table = "Base.CarLevel"
            Begin Extent = 
               Top = 48
               Left = 925
               Bottom = 211
               Right = 1119
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plate"
            Begin Extent = 
               Top = 238
               Left = 1027
               Bottom = 439
               Right = 1221
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Car"
            Begin Extent = 
               Top = 19
               Left = 649
               Bottom = 401
               Right = 843
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.PlateType"
            Begin Extent = 
               Top = 20
               Left = 1235
               Bottom = 183
               Right = 1429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.PlateCity"
            Begin Extent = 
               Top = 452
               Left = 801
               Bottom = 615
               Right = 995
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarType"
            Begin Extent = 
               Top = 189
               Left = 306
               Bottom = 352
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarSystem"
            Begin Extent = 
               Top = 352
               Left = 310
               Bottom = 515
               Right = 504
            En' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewCustomer'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'd
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarColor"
            Begin Extent = 
               Top = 523
               Left = 317
               Bottom = 686
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CarOwner"
            Begin Extent = 
               Top = 20
               Left = 351
               Bottom = 183
               Right = 545
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Owner"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 268
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1428
         Width = 1980
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 2256
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewCustomer'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewCustomer'
GO


/*
	UPDATE DB VERSION
*/
DECLARE @version	varchar(50) = '95-09-26-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO