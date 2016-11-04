USE [master]
GO
/****** Object:  Database [GasStation]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
CREATE DATABASE [GasStation] ON  PRIMARY 
( NAME = N'GasStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GasStation.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GasStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GasStation_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GasStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GasStation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GasStation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GasStation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GasStation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GasStation] SET ARITHABORT OFF 
GO
ALTER DATABASE [GasStation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GasStation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GasStation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GasStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GasStation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GasStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GasStation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GasStation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GasStation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GasStation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GasStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GasStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GasStation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GasStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GasStation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GasStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GasStation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GasStation] SET RECOVERY FULL 
GO
ALTER DATABASE [GasStation] SET  MULTI_USER 
GO
ALTER DATABASE [GasStation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GasStation] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GasStation', N'ON'
GO
USE [GasStation]
GO
/****** Object:  Table [dbo].[Base.CarColor]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarColor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NULL CONSTRAINT [DF_Base.CarColor_viewId]  DEFAULT (newid()),
	[color] [varchar](50) NULL,
 CONSTRAINT [PK_Base.CarColor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarFuel]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarFuel](
	[id] [int] NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[fuel] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.CarFuel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarLevel]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarLevel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[levelcar] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.CarLevel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarModel]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[model] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.CarModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarType]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
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
 CONSTRAINT [PK_Base.CarType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.OwnerType]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.OwnerType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.OwnerType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateCity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[city] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.PlateCity] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateCountry]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateCountry](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.PlateCountry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateLetter]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateLetter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[letter] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.PlateLetter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateType]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Base.PlateType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Car]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Car](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[carTypeId] [int] NOT NULL,
	[carColorId] [int] NOT NULL,
	[carModelId] [int] NOT NULL,
	[carLevelId] [int] NOT NULL,
	[carFuelId] [int] NOT NULL,
	[plateId] [int] NOT NULL,
	[tagId] [int] NOT NULL,
	[capacity] [smallint] NOT NULL,
	[chasisCode] [varchar](50) NOT NULL,
	[engineCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LegalOwner]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LegalOwner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[OrganizationCode] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LegalOwner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Owner]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Owner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[ownerTypeId] [int] NOT NULL,
	[realOwnerId] [int] NULL,
	[legalOwnerId] [int] NULL,
	[carId] [int] NOT NULL,
	[phone] [varchar](50) NULL,
	[mobile] [varchar](50) NOT NULL,
	[address] [varchar](50) NULL,
 CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plate]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[plateTypeId] [int] NOT NULL,
	[plateCityId] [int] NOT NULL,
	[plateCountryId] [int] NOT NULL,
	[plateLetterId] [int] NOT NULL,
	[plate_part1] [varchar](50) NOT NULL,
	[palte_part2] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Plate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RealOwner]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RealOwner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[nationalCode] [char](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[birthdate] [date] NULL,
	[birthdatelocal] [varchar](50) NULL,
 CONSTRAINT [PK_RealOwner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[EPC] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Traffic]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Traffic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewID] [uniqueidentifier] NOT NULL,
	[EPC] [varchar](50) NOT NULL,
	[trafficdate] [datetime] NOT NULL,
 CONSTRAINT [PK_Traffic] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UHF]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UHF](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[IP] [varchar](15) NOT NULL,
	[Port] [int] NOT NULL,
 CONSTRAINT [PK_UHF] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 04/11/2016 08:07:47 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[createdate] [date] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarColor] ON 

INSERT [dbo].[Base.CarColor] ([Id], [viewId], [color]) VALUES (1, N'7dbd0dce-613a-48d6-8de9-bfed6e556667', N'???')
INSERT [dbo].[Base.CarColor] ([Id], [viewId], [color]) VALUES (2, N'f57e8bce-8a7f-4a1c-96e3-0a73ae42ec49', N'????')
SET IDENTITY_INSERT [dbo].[Base.CarColor] OFF
SET IDENTITY_INSERT [dbo].[Base.CarType] ON 

INSERT [dbo].[Base.CarType] ([id], [viewId], [type]) VALUES (1, N'9453d451-2183-4454-9ac6-3fd560389e1a', N'?????')
INSERT [dbo].[Base.CarType] ([id], [viewId], [type]) VALUES (2, N'32212811-3b73-47d8-8af8-bd9640612bba', N'??????')
INSERT [dbo].[Base.CarType] ([id], [viewId], [type]) VALUES (3, N'5294d0f3-5402-4536-b973-9dedf3eb97b2', N'???????')
INSERT [dbo].[Base.CarType] ([id], [viewId], [type]) VALUES (4, N'20b4e264-aba1-49df-ac76-5b0fa81189d0', N'????')
INSERT [dbo].[Base.CarType] ([id], [viewId], [type]) VALUES (5, N'db71a8b0-5f94-4d11-bd27-3f9ed707459c', N'????? ?????')
SET IDENTITY_INSERT [dbo].[Base.CarType] OFF
ALTER TABLE [dbo].[Base.CarFuel] ADD  CONSTRAINT [DF_Base.CarFuel_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.CarLevel] ADD  CONSTRAINT [DF_Base.CarLevel_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.CarModel] ADD  CONSTRAINT [DF_Base.CarModel_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.OwnerType] ADD  CONSTRAINT [DF_Base.OwnerType_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.PlateCity] ADD  CONSTRAINT [DF_Base.PlateCity_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.PlateCountry] ADD  CONSTRAINT [DF_Base.PlateCountry_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.PlateLetter] ADD  CONSTRAINT [DF_Base.PlateLetter_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.PlateType] ADD  CONSTRAINT [DF_Base.PlateType_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Car] ADD  CONSTRAINT [DF_Car_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Car] ADD  CONSTRAINT [DF_Car_capacity]  DEFAULT ((0)) FOR [capacity]
GO
ALTER TABLE [dbo].[LegalOwner] ADD  CONSTRAINT [DF_LegalOwner_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Owner] ADD  CONSTRAINT [DF_Owner_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Plate] ADD  CONSTRAINT [DF_Plate_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[RealOwner] ADD  CONSTRAINT [DF_RealOwner_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Tag] ADD  CONSTRAINT [DF_Tag_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Traffic] ADD  CONSTRAINT [DF_Traffic_viewID]  DEFAULT (newid()) FOR [viewID]
GO
ALTER TABLE [dbo].[UHF] ADD  CONSTRAINT [DF_UHF_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarColor] FOREIGN KEY([carColorId])
REFERENCES [dbo].[Base.CarColor] ([Id])
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
REFERENCES [dbo].[Base.CarLevel] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarLevel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarModel] FOREIGN KEY([carModelId])
REFERENCES [dbo].[Base.CarModel] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarModel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarType] FOREIGN KEY([carTypeId])
REFERENCES [dbo].[Base.CarType] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarType]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Plate] FOREIGN KEY([plateId])
REFERENCES [dbo].[Plate] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Plate]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Tag] FOREIGN KEY([tagId])
REFERENCES [dbo].[Tag] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Tag]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_Base.OwnerType] FOREIGN KEY([ownerTypeId])
REFERENCES [dbo].[Base.OwnerType] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_Base.OwnerType]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_Car] FOREIGN KEY([carId])
REFERENCES [dbo].[Car] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_Car]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_LegalOwner] FOREIGN KEY([legalOwnerId])
REFERENCES [dbo].[LegalOwner] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_LegalOwner]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_RealOwner] FOREIGN KEY([realOwnerId])
REFERENCES [dbo].[RealOwner] ([Id])
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_RealOwner]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateCity] FOREIGN KEY([plateCityId])
REFERENCES [dbo].[Base.PlateCity] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateCity]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateCountry] FOREIGN KEY([plateCountryId])
REFERENCES [dbo].[Base.PlateCountry] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateCountry]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateLetter] FOREIGN KEY([plateLetterId])
REFERENCES [dbo].[Base.PlateLetter] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateLetter]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateType] FOREIGN KEY([plateTypeId])
REFERENCES [dbo].[Base.PlateType] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateType]
GO
USE [master]
GO
ALTER DATABASE [GasStation] SET  READ_WRITE 
GO
