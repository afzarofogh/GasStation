USE [GasStation]
GO
/****** Object:  Table [dbo].[Base.CarColor]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarColor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarColor_viewId]  DEFAULT (newid()),
	[color] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarColor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarFuel]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarFuel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarFuel_viewId]  DEFAULT (newid()),
	[fuel] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarFuel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarLevel]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarLevel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarLevel_viewId]  DEFAULT (newid()),
	[levelcar] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarLevel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarSystem]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarSystem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarModel_viewId]  DEFAULT (newid()),
	[system] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarModel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarType]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarType_viewId]  DEFAULT (newid()),
	[type] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.GridHeader]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.GridHeader](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.GridHeader_viewId]  DEFAULT (newid()),
	[name] [varchar](255) NOT NULL,
	[data] [text] NOT NULL,
 CONSTRAINT [PK_Base.GridHeader] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateCity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.PlateCity_viewId]  DEFAULT (newid()),
	[code] [varchar](3) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL CONSTRAINT [DF_Base.PlateCity_insertDate]  DEFAULT (getdate()),
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.PlateCity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateCountry]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateCountry](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.PlateCountry_viewId]  DEFAULT (newid()),
	[country] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.PlateCountry] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateType]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateType](
	[id] [int] IDENTITY(10,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.PlateType_viewId]  DEFAULT (newid()),
	[type] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.PlateType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Car]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Car](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Car_viewId]  DEFAULT (newid()),
	[carTypeId] [int] NOT NULL,
	[carColorId] [int] NOT NULL,
	[carSystemId] [int] NOT NULL,
	[carLevelId] [int] NOT NULL,
	[carFuelId] [int] NOT NULL,
	[plateId] [int] NOT NULL,
	[model] [varchar](5) NOT NULL,
	[status] [bit] NOT NULL,
	[capacity] [smallint] NOT NULL CONSTRAINT [DF_Car_capacity]  DEFAULT ((0)),
	[chasisCode] [varchar](50) NOT NULL,
	[engineCode] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CarOwner]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarOwner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_CarOwner_viewId]  DEFAULT (newid()),
	[carId] [int] NOT NULL,
	[ownerId] [int] NOT NULL,
	[type] [bit] NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_CarOwner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CarTag]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarTag](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_CarTag_viewId]  DEFAULT (newid()),
	[carId] [int] NOT NULL,
	[tagId] [int] NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [date] NULL,
 CONSTRAINT [PK_CarTag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HC.Sexuality]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HC.Sexuality](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_HC.Sexuality_viewId]  DEFAULT (newid()),
	[gen] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HC.Sexuality] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LegalOwner]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LegalOwner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_LegalOwner_viewId]  DEFAULT (newid()),
	[carOwnerId] [int] NOT NULL,
	[OrganizationCode] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_LegalOwner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Owner]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Owner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Owner_viewId]  DEFAULT (newid()),
	[nationalCode] [varchar](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[birthdate] [date] NULL,
	[birthdatelocal] [varchar](50) NULL,
	[gen] [int] NULL,
	[phone] [varchar](50) NULL,
	[mobile] [varchar](50) NOT NULL,
	[address] [varchar](50) NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plate]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Plate_viewId]  DEFAULT (newid()),
	[plateTypeId] [int] NOT NULL,
	[plateCityId] [int] NOT NULL,
	[plate] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Plate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System.Data]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[System.Data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_System_Data_viewId]  DEFAULT (newid()),
	[name] [varchar](50) NOT NULL,
	[value] [text] NOT NULL,
 CONSTRAINT [PK_System_Data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tag](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Tag_viewId]  DEFAULT (newid()),
	[tag] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Traffic]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traffic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[tagId] [int] NOT NULL,
	[trafficDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Traffic] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UHF]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UHF](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_UHF_viewId]  DEFAULT (newid()),
	[IP] [varchar](15) NOT NULL,
	[Port] [int] NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_UHF] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_User_viewId]  DEFAULT (newid()),
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[inserted] [datetime] NOT NULL CONSTRAINT [DF_User_createdate]  DEFAULT (getdate()),
	[enable] [tinyint] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[viewCustomer]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewCustomer]
AS
SELECT dbo.Car.id AS idCar, dbo.Owner.id, dbo.Owner.viewId, dbo.Owner.nationalCode, dbo.Owner.name, dbo.Owner.lastname, dbo.Owner.mobile, dbo.Plate.plate, dbo.[Base.PlateCity].city, dbo.[Base.PlateType].type, 
                  dbo.[Base.CarSystem].system, dbo.[Base.CarLevel].levelcar, dbo.[Base.CarColor].color, dbo.[Base.CarType].type AS typeCar
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
SET IDENTITY_INSERT [dbo].[Base.CarColor] ON 

INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'd8b3d630-473c-46b8-81e3-551c10f62058', N'قرمز', 2, CAST(N'2016-11-25 12:47:52.743' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'fbe36c34-7665-4cfb-8622-34b2b96ff0cc', N'سبز', 2, CAST(N'2016-11-25 15:36:44.727' AS DateTime), 2, CAST(N'2016-11-30 13:20:47.707' AS DateTime))
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'f089e525-f1f8-4ce9-aef6-691d33858b2a', N'آبي', 2, CAST(N'2016-11-30 13:26:28.290' AS DateTime), 2, CAST(N'2016-11-30 13:26:40.257' AS DateTime))
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'eed1b4d6-06db-4444-ae4f-7bb0ed750fb1', N'بنفش', 2, CAST(N'2016-11-30 13:27:31.887' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'c10df7f5-0fd0-4fdb-a04a-0fe8c8189ee1', N'سفيد', 2, CAST(N'2016-12-16 21:11:54.370' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'df2fe9b3-2743-4806-9486-aca4a214a935', N'زرشکي', 2, CAST(N'2016-12-16 21:18:54.017' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'0c0e086d-00bb-433f-a2c9-3af1d28967f6', N'نارنجي', 2, CAST(N'2016-12-16 21:28:16.723' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'33aaa7d4-0d87-401d-bac7-a460551feccb', N'نقره اي', 2, CAST(N'2016-12-16 21:37:22.257' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarColor] OFF
SET IDENTITY_INSERT [dbo].[Base.CarFuel] ON 

INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'dd1a7a3a-cf0f-4581-b3f9-d5e07a82b43c', N'بنزين', 2, CAST(N'2016-11-25 15:19:56.077' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'993c16fd-0858-4909-9a1d-64c0186a2f93', N'CNG', 2, CAST(N'2016-11-25 15:20:17.687' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarFuel] OFF
SET IDENTITY_INSERT [dbo].[Base.CarLevel] ON 

INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'52ffbe27-23e7-409f-be24-4a848f983f62', N'405 جي ال ايکس', 2, CAST(N'2016-11-30 16:21:15.233' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'd44637c9-1799-476e-a4ce-25374deddf8d', N'وانت بار', 2, CAST(N'2016-12-16 17:44:16.607' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'd2ed977e-fd8d-43cd-aee6-5681eae980b0', N'33X', 2, CAST(N'2016-12-16 21:11:40.427' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'514a6025-3ce8-42e5-9469-f63c515f133f', N'تيپ 2', 2, CAST(N'2016-12-16 21:19:10.440' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (6, N'f8fe51a2-94c9-4548-94bd-357468c9f19f', N'سمند', 2, CAST(N'2016-12-16 21:37:32.113' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarLevel] OFF
SET IDENTITY_INSERT [dbo].[Base.CarSystem] ON 

INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'8b5d8b57-2c53-45df-ad6d-ffa74b16979f', N'پژو', 2, CAST(N'2016-12-04 22:49:32.157' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (6, N'a72f0912-23ab-4593-81df-6fcc71a13495', N'باري', 2, CAST(N'2016-12-16 17:43:50.260' AS DateTime), 2, CAST(N'2016-12-16 17:43:59.830' AS DateTime))
INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'd8256229-1f16-4bbf-b230-a397e13669b2', N'مگان', 2, CAST(N'2016-12-16 21:11:23.997' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarSystem] OFF
SET IDENTITY_INSERT [dbo].[Base.CarType] ON 

INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'3db513b9-06d5-4999-8c14-dd75f866d38f', N'سواري', 2, CAST(N'2016-11-30 16:19:40.897' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'b1ebb5e5-8a13-4b83-b333-7dae975fe0c0', N'وانت', 2, CAST(N'2016-11-30 17:11:51.300' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'96da2cae-a388-4095-9826-ce711e668db8', N'نيسان', 2, CAST(N'2016-11-30 17:11:55.667' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarType] OFF
SET IDENTITY_INSERT [dbo].[Base.GridHeader] ON 

INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (22, N'40801e5c-b2bd-41cf-bab9-1644f95bf237', N'CustomerViewForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":1,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":150},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":5,"width":150},{"field":"type","caption":"نوع پلاک","visible":true,"readOnly":true,"position":6,"width":150},{"field":"city","caption":"شهر پلاک","visible":true,"readOnly":true,"position":7,"width":150},{"field":"typeCar","caption":"نوع خودرو","visible":true,"readOnly":true,"position":8,"width":150},{"field":"system","caption":"سيستم خودرو","visible":true,"readOnly":true,"position":9,"width":150},{"field":"color","caption":"رنگ خودرو","visible":true,"readOnly":true,"position":10,"width":150},{"field":"levelcar","caption":"تيپ خودرو","visible":true,"readOnly":true,"position":11,"width":150},{"field":"model","caption":"مدل خودرو","visible":true,"readOnly":true,"position":12,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (23, N'a532e2e3-4fe5-4423-9e8a-dc333a2f8a91', N'CarColorForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"color","caption":"رنگ","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (24, N'32d8c503-8b2a-4f03-968a-fc6a545a143e', N'CarLevelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"levelcar","caption":"تيپ","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (25, N'8e3667d9-1c59-4a48-9492-4fd804ce85ac', N'CarFuelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"fuel","caption":"سوخت","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (26, N'2194f04f-f75c-4f41-8cf3-0c3f5b204ba5', N'CarSystemForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"system","caption":"سيستم خودرو","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (27, N'7a408a70-c420-42a5-a2d0-42172d483b8c', N'CarTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"type","caption":"نوع خودرو","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (28, N'0225be78-1339-40e0-8fa8-4b1f139651c1', N'PlateTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"type","caption":"نوع پلاک","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (29, N'515b3287-0a0d-468d-9f7d-041356a4f133', N'PlateCityForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"city","caption":"شهر","visible":true,"readOnly":true,"position":1,"width":150},{"field":"code","caption":"کد استان","visible":true,"readOnly":true,"position":1,"width":150}]}')
SET IDENTITY_INSERT [dbo].[Base.GridHeader] OFF
SET IDENTITY_INSERT [dbo].[Base.PlateCity] ON 

INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (166, N'd89f3e65-4614-42f1-90b4-116a4f68e9e4', N'11', N'تهران شمال', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (167, N'13580c42-81d3-4e88-ac47-0e8e024f4920', N'12', N'مشهد', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (168, N'fa56f2d6-b345-4818-adc4-f15d42a9bba1', N'13', N'اصفهان', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (169, N'17dccf50-8fc6-4dff-b2b9-c2b267d4b77d', N'14', N'اهواز', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (170, N'81f2d663-e19c-4044-9877-8a2d55e36c6a', N'15', N'تبريز', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (171, N'b85d1a14-b7b6-4be0-a0c5-90e52e9102c8', N'16', N'قم', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (172, N'972d9a92-46fb-41e9-8f24-56753fab5b50', N'17', N'اروميه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (173, N'd62b0e6c-6a6b-42e8-a17e-e8db0bdf6501', N'18', N'همدان', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (174, N'dbdd3de0-af94-4cb6-ab8d-5b3c44f72d74', N'19', N'کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (175, N'48f9c2b5-c812-4c02-ba43-15bcedf9771c', N'21', N'استان تهران', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (176, N'b0dee809-3e46-4e9b-98dd-b2e586e685e9', N'22', N'تهران مرکز', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (177, N'b04dbae6-1a7d-4ddd-b6ea-173af9f1da65', N'23', N'استان اصفهان', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (178, N'48335aae-6a91-45e1-8657-f523ac56db00', N'24', N'استان خوزستان', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (179, N'4d1e6965-8c9f-4cab-8e0d-10c62b691c2a', N'25', N'استان آذربايجان شرقي', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (180, N'cd3b580d-e649-49b9-a3a3-6188472bfd12', N'26', N'استان قم', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (181, N'a4b15a25-9f77-423c-934b-898ed12643a3', N'27', N'استان آربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (182, N'37445188-1dab-4dce-abdf-facf6ed8d9b9', N'28', N'استان همدان', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (183, N'60d5c0c0-4b88-44ac-bd15-f80022dd9b3d', N'29', N'استان کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (184, N'e415725c-ce86-4305-8366-cd2e1c1d155e', N'31', N'سنندج', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (185, N'0a0edc4f-5cbd-46c4-a169-d65c92f94ce1', N'32', N'استان خراسان', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (186, N'55834de5-744d-418a-85b8-e07f97a89e8b', N'33', N'تهران جنوب', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (190, N'b64df916-d05f-43c1-8993-81142dad7515', N'37', N'استان آذربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.137' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (193, N'71212ea5-81df-4b98-8695-eed4d4429bc5', N'41', N'استان کردستان', 2, CAST(N'2016-11-30 15:13:34.143' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (197, N'859de2f5-1457-4219-97ac-f388839b6a3b', N'45', N'کرمان', 2, CAST(N'2016-11-30 15:13:34.163' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (198, N'f53c5c34-1876-4e95-aa62-19a7a2aa1dd0', N'46', N'رشت', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (199, N'9e959359-3cbf-4abc-a6fd-8e50454026f0', N'47', N'اراک', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (200, N'404d7e25-67b6-481d-98b6-46fa6cd38293', N'48', N'بوشهر', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (201, N'd36c8d08-e481-4fdc-bb2b-6df98b2f30b9', N'49', N'استان کهکيلويه و بوير احمد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (202, N'e2c28ca4-1d6f-4243-a606-de919c50f136', N'51', N'خرم آباد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (205, N'8710b474-9a56-43ed-a895-15d923ed91bc', N'54', N'يزد', 2, CAST(N'2016-11-30 15:13:34.173' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (206, N'6bb8f311-1b12-46a3-8497-2a38474be6dc', N'55', N'تهران مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (207, N'4f1a41c4-594c-4ebb-9c78-b093ae9d1b8f', N'56', N'گيلان', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (208, N'dca07382-9cb8-4561-a74e-4bd710251a3f', N'57', N'استان مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (209, N'cbf80c6d-eba4-4168-ba88-ce2ebe239483', N'58', N'استان بوشهر', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (210, N'c1c56ac3-5960-45d0-98c6-4e163fa43ead', N'59', N'گرگان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (211, N'5cc3434a-59f1-425c-80bc-5c53870854ce', N'61', N'استان لرستان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (212, N'73e3e333-2acf-4722-bb0b-83e2bf04fb96', N'62', N'ساري', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (213, N'21ffd625-4f7d-49a1-ac68-6649eb7faeaa', N'63', N'شيراز', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (214, N'886c7321-954e-4250-b779-71bd090ea8b4', N'64', N'استان يزد', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (215, N'e6cac1e3-bd5b-40c3-8bc4-1dd8d5507640', N'65', N'استان کرمان', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (218, N'6e5ee6e0-55e8-4dd4-a043-d2c35c144d95', N'68', N'کرج', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (219, N'7bcb20a2-f287-4bc2-9653-94ab67a5be93', N'69', N'استان گرگان', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (220, N'b0ee0e4f-0d89-4575-90fb-dd3cfbd7c488', N'71', N'شهرکرد', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (221, N'2dce554a-8272-4805-85f5-7e9a5f34dd5b', N'72', N'استان مازندران', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (222, N'e36e9e76-7427-470f-95b9-25a3963eaaa9', N'73', N'استان فارس', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (225, N'b8d54fe7-3584-4f02-9801-50ba84d73064', N'76', N'استان گيلان', 2, CAST(N'2016-11-30 15:13:34.193' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (227, N'7261c50b-23c7-40a1-9e71-3eb1cc125e7b', N'78', N'شهرستان هاي تهران', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (228, N'd140671e-f99d-4044-b984-851ef9fccadf', N'79', N'قزوين', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (229, N'42d92392-780b-47a1-8a33-1341252a5e11', N'81', N'استان چهار محال و بختياري', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (232, N'f1d08f21-4690-41b3-bdec-5f920c52ee74', N'84', N'بندرعباس', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (233, N'19935827-e134-4371-9171-b00891200bb1', N'85', N'زاهدان', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (234, N'd3c08b03-94cb-43d2-92bc-4ca7c5bf2104', N'86', N'سمنان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (235, N'12a1126e-24f2-44ab-9507-26611a6d0160', N'87', N'زنجان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (237, N'e5109647-b0c5-4587-a6da-587a15b29047', N'89', N'استان قزوين', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (238, N'ddc5677d-0fd6-4fe2-baff-7430389dfbc0', N'91', N'اردبيل', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (241, N'5695724b-9f54-45fa-9a95-bd7d6f67e652', N'94', N'استان هرمزگان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (242, N'3fa1a814-c237-429c-8e08-a558084ee817', N'95', N'استان سيستان و بلوچستان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (243, N'15df7003-a5cc-44e9-88e5-8c5e4230d44f', N'96', N'استان سمنان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (244, N'4a8e8504-7539-4db7-8978-c20fabb72894', N'97', N'استان زنجان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (245, N'7272f1f3-6df9-4616-b84d-bf25f5c55d0b', N'98', N'ايلام', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (249, N'7c8964a8-fdd3-4a1b-b7b5-b7d66ec3a87c', N'99', N'تهران جنوب', 2, CAST(N'2016-11-30 15:18:52.400' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.PlateCity] OFF
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] ON 

INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'6b018379-cc17-4d3b-9ad8-aca7c679dbfe', N'ايران', 2, CAST(N'2016-11-19 00:52:44.863' AS DateTime), 2, CAST(N'2016-11-19 00:52:53.523' AS DateTime))
INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'c0f6d287-00f8-41e5-a42d-0e2dacbcdf44', N'ترکيه', 2, CAST(N'2016-11-19 00:52:49.507' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] OFF
SET IDENTITY_INSERT [dbo].[Base.PlateType] ON 

INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'24a22ab1-17c2-4208-ade3-57a06a6271e6', N'عادي', 2, CAST(N'2016-12-02 12:05:11.277' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'48d690e1-3024-4d70-a47c-854bddda36ce', N'تاکسي', 2, CAST(N'2016-12-02 12:05:16.683' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'91d2d573-c10b-4cb4-908d-5113ca9dc9f6', N'دولتي', 2, CAST(N'2016-12-02 12:05:23.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'c91abdf8-d69d-42aa-9113-8a6af85fab8e', N'معلولين', 2, CAST(N'2016-12-02 12:06:45.820' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'b3078074-c59f-4481-88cb-6becc5aeb0ee', N'موتورسيکلت', 2, CAST(N'2016-12-02 12:06:56.460' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.PlateType] OFF
SET IDENTITY_INSERT [dbo].[Car] ON 

INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (33, N'046b1f20-2f8a-4dfb-b2f0-3c88e612fb99', 3, 4, 5, 2, 7, 39, N'10', 1, 13, N'222', N'111', 2, CAST(N'2016-12-23 15:13:24.627' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (34, N'fc3eb807-3c69-40bb-ab9e-4444f408e5df', 4, 8, 5, 3, 7, 40, N'12', 1, 13, N'4141', N'1424', 2, CAST(N'2016-12-23 15:18:09.233' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (35, N'a5ca39ce-e19b-4975-8edc-c2a412a45451', 3, 10, 7, 6, 8, 41, N'10', 1, 50, N'10', N'11', 2, CAST(N'2016-12-23 15:54:07.693' AS DateTime), 2, CAST(N'2016-12-23 16:01:26.930' AS DateTime))
SET IDENTITY_INSERT [dbo].[Car] OFF
SET IDENTITY_INSERT [dbo].[CarOwner] ON 

INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (33, N'7b255bab-312e-4168-b601-923e384e4e04', 33, 34, 0, 2, CAST(N'2016-12-23 15:13:24.640' AS DateTime), NULL, NULL)
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (34, N'a8a17e2d-a9a7-4e3a-9175-63ee27c8110f', 34, 34, 0, 2, CAST(N'2016-12-23 15:18:09.293' AS DateTime), NULL, NULL)
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (35, N'd8ecca03-0209-4c2e-9efc-9d058a9993e1', 35, 35, 1, 2, CAST(N'2016-12-23 15:54:07.737' AS DateTime), 2, CAST(N'2016-12-23 16:01:26.947' AS DateTime))
SET IDENTITY_INSERT [dbo].[CarOwner] OFF
SET IDENTITY_INSERT [dbo].[CarTag] ON 

INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (21, N'8e925118-431d-444a-8f39-2b351ca33792', 33, 26, 2, CAST(N'2016-12-23' AS Date), NULL, NULL)
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (22, N'cf160969-e144-41a4-a335-1208c02d93f9', 34, 27, 2, CAST(N'2016-12-23' AS Date), NULL, NULL)
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (23, N'670207f2-4b1e-4a46-be29-2b80ae479558', 35, 28, 2, CAST(N'2016-12-23' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[CarTag] OFF
SET IDENTITY_INSERT [dbo].[HC.Sexuality] ON 

INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (1, N'85217f29-a579-4bbe-a590-5a4fd262d3fa', N'زن')
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (2, N'0f56a913-e787-4929-a3bc-abf6105ea38e', N'مرد')
SET IDENTITY_INSERT [dbo].[HC.Sexuality] OFF
SET IDENTITY_INSERT [dbo].[LegalOwner] ON 

INSERT [dbo].[LegalOwner] ([id], [viewId], [carOwnerId], [OrganizationCode], [name], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'9f538c8e-3dab-4587-9a73-0b126c4d4adb', 35, N'12', N'سازمان امور مهندسين', 2, CAST(N'2016-12-23 15:54:07.747' AS DateTime), 2, CAST(N'2016-12-23 16:01:26.970' AS DateTime))
SET IDENTITY_INSERT [dbo].[LegalOwner] OFF
SET IDENTITY_INSERT [dbo].[Owner] ON 

INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (34, N'72b6e014-5a17-4373-92d6-d512b83024d4', N'4324260869', N'مرجان', N'قبادي فرد', CAST(N'1367-10-10' AS Date), N'', 1, N'', N'09193862018', N'', 2, CAST(N'2016-12-23 15:13:24.553' AS DateTime), 2, CAST(N'2016-12-23 15:18:09.213' AS DateTime))
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (35, N'18dc38d0-1765-496c-af4a-a615611f4c8b', N'4320686871', N'علي', N'اکبري', CAST(N'1364-10-10' AS Date), N'قزوين', 2, N'', N'09121829155', N'', 2, CAST(N'2016-12-23 15:54:07.623' AS DateTime), 2, CAST(N'2016-12-23 16:01:26.847' AS DateTime))
SET IDENTITY_INSERT [dbo].[Owner] OFF
SET IDENTITY_INSERT [dbo].[Plate] ON 

INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (39, N'ee34fe48-d0aa-42d6-9476-ebef16e39080', 10, 227, N'10_ق_121_78', 2, CAST(N'2016-12-23 15:13:24.437' AS DateTime), NULL, NULL)
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (40, N'b0cb47bb-0772-4ec4-b6f5-488d727fdbb4', 10, 227, N'45_ع_787_78', 2, CAST(N'2016-12-23 15:18:09.203' AS DateTime), NULL, NULL)
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (41, N'e1f519c9-7c47-4917-9a65-0268284b7ada', 10, 228, N'41_ق_424_79', 2, CAST(N'2016-12-23 15:54:07.610' AS DateTime), 2, CAST(N'2016-12-23 16:01:26.830' AS DateTime))
SET IDENTITY_INSERT [dbo].[Plate] OFF
SET IDENTITY_INSERT [dbo].[System.Data] ON 

INSERT [dbo].[System.Data] ([id], [viewId], [name], [value]) VALUES (3, N'dd010c7e-f228-467b-9eaa-42f4a94dad9c', N'DB-Version', N'95-09-26-2')
SET IDENTITY_INSERT [dbo].[System.Data] OFF
SET IDENTITY_INSERT [dbo].[Tag] ON 

INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (24, N'62c8ea83-41ea-451c-ab36-3c474550338e', N'121212', 2, CAST(N'2016-10-10 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (26, N'9ac4394c-14b1-4f74-bc90-3f92bf11c30f', N'4444444444', 2, CAST(N'2016-12-23 15:13:24.650' AS DateTime), NULL, NULL)
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (27, N'a594c34e-ead2-4f1b-ba45-8cf5212634b7', N'777777777', 2, CAST(N'2016-12-23 15:18:09.303' AS DateTime), NULL, NULL)
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (28, N'50d1ebd6-0f1a-4562-a458-efad3f44135c', N'2424242', 2, CAST(N'2016-12-23 15:54:07.803' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tag] OFF
SET IDENTITY_INSERT [dbo].[UHF] ON 

INSERT [dbo].[UHF] ([id], [viewId], [IP], [Port], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'2cf20660-a678-48d2-9153-6fffc958e5da', N'127.0.0.1', 1470, 2, CAST(N'2016-03-12 00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[UHF] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (2, N'6b5d6474-8382-47ba-9f2b-aa4edd7b9ee0', N'محمد', N'علويي', N'admin', N'123', CAST(N'2016-11-25 10:30:50.900' AS DateTime), 1)
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (3, N'b30586e2-ca38-4b1f-9ae9-4a8551e1afa0', N'مرجان', N'قبادي', N'mj', N'123', CAST(N'2016-11-30 15:10:58.400' AS DateTime), 1)
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (4, N'0467305e-f37d-4945-aa08-92dd838c5fa7', N'Service', N'', N'ServiceUser', N'$3r\/Ic3U53R', CAST(N'2016-12-07 12:11:21.967' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[User] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LegalOwner]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
ALTER TABLE [dbo].[LegalOwner] ADD  CONSTRAINT [IX_LegalOwner] UNIQUE NONCLUSTERED 
(
	[OrganizationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Traffic] ADD  CONSTRAINT [DF_Traffic_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.CarColor]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarColor_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarColor] CHECK CONSTRAINT [FK_Base.CarColor_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarColor]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarColor_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarColor] CHECK CONSTRAINT [FK_Base.CarColor_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarFuel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarFuel_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarFuel] CHECK CONSTRAINT [FK_Base.CarFuel_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarFuel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarFuel_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarFuel] CHECK CONSTRAINT [FK_Base.CarFuel_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarLevel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarLevel_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarLevel] CHECK CONSTRAINT [FK_Base.CarLevel_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarLevel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarLevel_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarLevel] CHECK CONSTRAINT [FK_Base.CarLevel_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarSystem]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarModel_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarSystem] CHECK CONSTRAINT [FK_Base.CarModel_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarSystem]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarModel_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarSystem] CHECK CONSTRAINT [FK_Base.CarModel_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarType]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarType_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarType] CHECK CONSTRAINT [FK_Base.CarType_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarType]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarType_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarType] CHECK CONSTRAINT [FK_Base.CarType_User_Modify]
GO
ALTER TABLE [dbo].[Base.PlateCity]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateCity_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateCity] CHECK CONSTRAINT [FK_Base.PlateCity_User_Insert]
GO
ALTER TABLE [dbo].[Base.PlateCity]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateCity_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateCity] CHECK CONSTRAINT [FK_Base.PlateCity_User_Modify]
GO
ALTER TABLE [dbo].[Base.PlateType]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateType_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateType] CHECK CONSTRAINT [FK_Base.PlateType_User_Insert]
GO
ALTER TABLE [dbo].[Base.PlateType]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateType_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateType] CHECK CONSTRAINT [FK_Base.PlateType_User_Modify]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarColor] FOREIGN KEY([carColorId])
REFERENCES [dbo].[Base.CarColor] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarColor]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarFuel] FOREIGN KEY([carFuelId])
REFERENCES [dbo].[Base.CarFuel] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarFuel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarLevel] FOREIGN KEY([carLevelId])
REFERENCES [dbo].[Base.CarLevel] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarLevel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarSystem] FOREIGN KEY([carSystemId])
REFERENCES [dbo].[Base.CarSystem] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarSystem]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarType] FOREIGN KEY([carTypeId])
REFERENCES [dbo].[Base.CarType] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarType]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Plate] FOREIGN KEY([plateId])
REFERENCES [dbo].[Plate] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Plate]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_User_Insert]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_User_Modify]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_Car] FOREIGN KEY([carId])
REFERENCES [dbo].[Car] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_Car]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_Owner] FOREIGN KEY([ownerId])
REFERENCES [dbo].[Owner] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_Owner]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_User_Insert]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_User_Modify]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_Car] FOREIGN KEY([carId])
REFERENCES [dbo].[Car] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_Car]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_Tag] FOREIGN KEY([tagId])
REFERENCES [dbo].[Tag] ([id])
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_Tag]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_User_Insert]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_User_Modify]
GO
ALTER TABLE [dbo].[LegalOwner]  WITH CHECK ADD  CONSTRAINT [FK_LegalOwner_CarOwner] FOREIGN KEY([carOwnerId])
REFERENCES [dbo].[CarOwner] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LegalOwner] CHECK CONSTRAINT [FK_LegalOwner_CarOwner]
GO
ALTER TABLE [dbo].[LegalOwner]  WITH CHECK ADD  CONSTRAINT [FK_LegalOwner_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[LegalOwner] CHECK CONSTRAINT [FK_LegalOwner_User_Insert]
GO
ALTER TABLE [dbo].[LegalOwner]  WITH CHECK ADD  CONSTRAINT [FK_LegalOwner_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[LegalOwner] CHECK CONSTRAINT [FK_LegalOwner_User_Modify]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_User_Insert]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_User_Modify]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateCity] FOREIGN KEY([plateCityId])
REFERENCES [dbo].[Base.PlateCity] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateCity]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateType] FOREIGN KEY([plateTypeId])
REFERENCES [dbo].[Base.PlateType] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateType]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_User_Insert]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_User_Modify]
GO
ALTER TABLE [dbo].[Tag]  WITH CHECK ADD  CONSTRAINT [FK_Tag_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Tag] CHECK CONSTRAINT [FK_Tag_User_Insert]
GO
ALTER TABLE [dbo].[Tag]  WITH CHECK ADD  CONSTRAINT [FK_Tag_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Tag] CHECK CONSTRAINT [FK_Tag_User_Modify]
GO
ALTER TABLE [dbo].[Traffic]  WITH CHECK ADD  CONSTRAINT [FK_Traffic_Tag] FOREIGN KEY([tagId])
REFERENCES [dbo].[Tag] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Traffic] CHECK CONSTRAINT [FK_Traffic_Tag]
GO
ALTER TABLE [dbo].[UHF]  WITH CHECK ADD  CONSTRAINT [FK_UHF_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[UHF] CHECK CONSTRAINT [FK_UHF_User_Insert]
GO
ALTER TABLE [dbo].[UHF]  WITH CHECK ADD  CONSTRAINT [FK_UHF_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[UHF] CHECK CONSTRAINT [FK_UHF_User_Modify]
GO
/****** Object:  StoredProcedure [dbo].[spTrafficRegisterByService]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[spTrafficRegisterByService]
(
	@tagData		varchar(50),
	@insertedById	int,
	@trafficDate	datetime,
	@intervalTime	int				-- MINUTES
)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE	@result	int;
	DECLARE	@tagId	int;

	-- Insert Tag
	SELECT
			@tagId = id
	FROM
			[Tag]
	WHERE
			(tag = @tagData);

	-- Insert if not exists
	IF (@tagId IS NULL)
		BEGIN
			INSERT INTO
					[tag]
					(tag, insertedById, insertDate)
			VALUES
					(@tagData, @insertedById, getDate());

			SET @tagId	= SCOPE_IDENTITY ();
		END

	-- Register Traffic
	IF (NOT EXISTS (
		SELECT
				*
		FROM
				(
					SELECT
							MAX (trafficDate) AS trafficDate
					FROM
							[Traffic]
					WHERE
							(tagId = @tagId)
				) AS tBase
		WHERE
				(DATEDIFF (MINUTE, GETDATE (), trafficDate) < @intervalTime)
	))
		BEGIN	
			INSERT INTO
					[Traffic]
					(tagId, trafficDate)
			VALUES
					(@tagId, @trafficDate);

			-- Set output
			SET	@result	= SCOPE_IDENTITY ();
		END
	ELSE
		SET	@result	= -1;	-- INTERVAL ERROR

	return  @result;
END

GO
/****** Object:  StoredProcedure [dbo].[spUserDelete]    Script Date: 02/02/2017 11:20:10 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUserDelete]
(
	@userId	int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM 
			[User]
	WHERE
			(id = @userId);

	SELECT @@ROWCOUNT;
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[5] 2[11] 3) )"
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
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
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
               Top = 175
               Left = 48
               Bottom = 338
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.PlateCity"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarType"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarSystem"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 242
            End
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewCustomer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarColor"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 242
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
