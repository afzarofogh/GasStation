USE [GasStation]
GO
SET IDENTITY_INSERT [dbo].[Base.GridHeader] ON 

GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (1, N'9ea64b2b-d3d3-412a-815a-ac5656958124', N'CarTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"type","caption":"نوع خودرو","visible":true,"readOnly":true,"position":1}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (2, N'5ebc3db1-a608-4452-a14c-6ecb702a6a7d', N'PlateCityForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"city","caption":"شهر","visible":true,"readOnly":true,"position":1}]}')
GO
SET IDENTITY_INSERT [dbo].[Base.GridHeader] OFF
GO


/*
	UPDATE DB VERSION
*/
DECLARE @version	varchar(50) = '95-08-30-2';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO