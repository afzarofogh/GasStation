USE [master]
GO
/****** Object:  Database [GasStation]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE DATABASE [GasStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GasStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GasStation.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GasStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GasStation_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GasStation] SET COMPATIBILITY_LEVEL = 120
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
ALTER DATABASE [GasStation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GasStation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GasStation] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GasStation', N'ON'
GO
USE [GasStation]
GO
/****** Object:  User [admin]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [admin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [admin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [admin]
GO
/****** Object:  Table [dbo].[Base.CarColor]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarFuel]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarLevel]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarSystem]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarType]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.GridHeader]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.PlateCountry]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Base.PlateType]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateType](
	[id] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Car]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
	[carSystemId] [int] NOT NULL,
	[carLevelId] [int] NOT NULL,
	[carFuelId] [int] NOT NULL,
	[plateId] [int] NOT NULL,
	[model] [varchar](5) NOT NULL,
	[status] [bit] NOT NULL,
	[capacity] [smallint] NOT NULL,
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
/****** Object:  Table [dbo].[CarOwner]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarOwner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
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
/****** Object:  Table [dbo].[CarTag]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarTag](
	[id] [int] NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[carId] [int] NOT NULL,
	[tagId] [int] NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LegalOwner]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LegalOwner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
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
/****** Object:  Table [dbo].[Owner]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Owner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
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
/****** Object:  Table [dbo].[Plate]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
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
/****** Object:  Table [dbo].[System.Data]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[Tag]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tag](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
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
/****** Object:  Table [dbo].[Traffic]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
/****** Object:  Table [dbo].[UHF]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UHF](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
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
/****** Object:  Table [dbo].[User]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
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
SET IDENTITY_INSERT [dbo].[Base.CarColor] ON 

GO
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'd8b3d630-473c-46b8-81e3-551c10f62058', N'قرمز', 2, CAST(N'2016-11-25 12:47:52.743' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'fbe36c34-7665-4cfb-8622-34b2b96ff0cc', N'سبز', 2, CAST(N'2016-11-25 15:36:44.727' AS DateTime), 2, CAST(N'2016-11-30 13:20:47.707' AS DateTime))
GO
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'f089e525-f1f8-4ce9-aef6-691d33858b2a', N'آبي', 2, CAST(N'2016-11-30 13:26:28.290' AS DateTime), 2, CAST(N'2016-11-30 13:26:40.257' AS DateTime))
GO
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'eed1b4d6-06db-4444-ae4f-7bb0ed750fb1', N'بنفش', 2, CAST(N'2016-11-30 13:27:31.887' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarColor] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarFuel] ON 

GO
INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'dd1a7a3a-cf0f-4581-b3f9-d5e07a82b43c', N'بنزين', 2, CAST(N'2016-11-25 15:19:56.077' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'993c16fd-0858-4909-9a1d-64c0186a2f93', N'CNG', 2, CAST(N'2016-11-25 15:20:17.687' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarFuel] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarLevel] ON 

GO
INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'52ffbe27-23e7-409f-be24-4a848f983f62', N'405 جي ال ايکس', 2, CAST(N'2016-11-30 16:21:15.233' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarLevel] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarSystem] ON 

GO
INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'755d7748-b485-4e71-8f61-558c47776a49', N'پژو', 2, CAST(N'2016-11-30 16:19:12.583' AS DateTime), 2, CAST(N'2016-11-30 16:19:32.253' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Base.CarSystem] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarType] ON 

GO
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'3db513b9-06d5-4999-8c14-dd75f866d38f', N'سواري', 2, CAST(N'2016-11-30 16:19:40.897' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'b1ebb5e5-8a13-4b83-b333-7dae975fe0c0', N'وانت', 2, CAST(N'2016-11-30 17:11:51.300' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'96da2cae-a388-4095-9826-ce711e668db8', N'نيسان', 2, CAST(N'2016-11-30 17:11:55.667' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarType] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.GridHeader] ON 

GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (1, N'9ea64b2b-d3d3-412a-815a-ac5656958124', N'CarTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"type","caption":"نوع خودرو","visible":true,"readOnly":true,"position":1}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (3, N'67b3ee4b-a625-493e-9d26-9b1b4f362d03', N'CarColorForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"color","caption":"رنگ","visible":true,"readOnly":true,"position":1}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (4, N'2a6945e6-1211-4d0f-adad-6556419c878d', N'CarFuelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"fuel","caption":"سوخت","visible":true,"readOnly":true,"position":1}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (6, N'13aa4859-e41d-449e-af39-41f99520a5c1', N'CarSystemForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"system","caption":"سيستم خودرو","visible":true,"readOnly":true,"position":1}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (7, N'07207ce7-c121-4d2d-83f7-8a8526b43d1e', N'PlateTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"type","caption":"نوع پلاک","visible":true,"readOnly":true,"position":1}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (8, N'6bf120b9-9a04-46e3-8429-0d7e2ada8729', N'CarLevelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0},{"field":"levelcar","caption":"تيپ","visible":true,"readOnly":true,"position":1}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (9, N'48418761-2741-4271-9882-04837e27f9d4', N'PlateCityForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0},{"field":"city","caption":"شهر","visible":true,"readOnly":true,"position":1},{"field":"code","caption":"کد استان","visible":true,"readOnly":true,"position":1}]}')
GO
SET IDENTITY_INSERT [dbo].[Base.GridHeader] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCity] ON 

GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (166, N'd89f3e65-4614-42f1-90b4-116a4f68e9e4', N'11', N'تهران شمال', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (167, N'13580c42-81d3-4e88-ac47-0e8e024f4920', N'12', N'مشهد', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (168, N'fa56f2d6-b345-4818-adc4-f15d42a9bba1', N'13', N'اصفهان', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (169, N'17dccf50-8fc6-4dff-b2b9-c2b267d4b77d', N'14', N'اهواز', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (170, N'81f2d663-e19c-4044-9877-8a2d55e36c6a', N'15', N'تبريز', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (171, N'b85d1a14-b7b6-4be0-a0c5-90e52e9102c8', N'16', N'قم', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (172, N'972d9a92-46fb-41e9-8f24-56753fab5b50', N'17', N'اروميه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (173, N'd62b0e6c-6a6b-42e8-a17e-e8db0bdf6501', N'18', N'همدان', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (174, N'dbdd3de0-af94-4cb6-ab8d-5b3c44f72d74', N'19', N'کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (175, N'48f9c2b5-c812-4c02-ba43-15bcedf9771c', N'21', N'استان تهران', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (176, N'b0dee809-3e46-4e9b-98dd-b2e586e685e9', N'22', N'تهران مرکز', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (177, N'b04dbae6-1a7d-4ddd-b6ea-173af9f1da65', N'23', N'استان اصفهان', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (178, N'48335aae-6a91-45e1-8657-f523ac56db00', N'24', N'استان خوزستان', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (179, N'4d1e6965-8c9f-4cab-8e0d-10c62b691c2a', N'25', N'استان آذربايجان شرقي', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (180, N'cd3b580d-e649-49b9-a3a3-6188472bfd12', N'26', N'استان قم', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (181, N'a4b15a25-9f77-423c-934b-898ed12643a3', N'27', N'استان آربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (182, N'37445188-1dab-4dce-abdf-facf6ed8d9b9', N'28', N'استان همدان', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (183, N'60d5c0c0-4b88-44ac-bd15-f80022dd9b3d', N'29', N'استان کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (184, N'e415725c-ce86-4305-8366-cd2e1c1d155e', N'31', N'سنندج', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (185, N'0a0edc4f-5cbd-46c4-a169-d65c92f94ce1', N'32', N'استان خراسان', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (186, N'55834de5-744d-418a-85b8-e07f97a89e8b', N'33', N'تهران جنوب', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (190, N'b64df916-d05f-43c1-8993-81142dad7515', N'37', N'استان آذربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.137' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (193, N'71212ea5-81df-4b98-8695-eed4d4429bc5', N'41', N'استان کردستان', 2, CAST(N'2016-11-30 15:13:34.143' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (197, N'859de2f5-1457-4219-97ac-f388839b6a3b', N'45', N'کرمان', 2, CAST(N'2016-11-30 15:13:34.163' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (198, N'f53c5c34-1876-4e95-aa62-19a7a2aa1dd0', N'46', N'رشت', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (199, N'9e959359-3cbf-4abc-a6fd-8e50454026f0', N'47', N'اراک', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (200, N'404d7e25-67b6-481d-98b6-46fa6cd38293', N'48', N'بوشهر', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (201, N'd36c8d08-e481-4fdc-bb2b-6df98b2f30b9', N'49', N'استان کهکيلويه و بوير احمد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (202, N'e2c28ca4-1d6f-4243-a606-de919c50f136', N'51', N'خرم آباد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (205, N'8710b474-9a56-43ed-a895-15d923ed91bc', N'54', N'يزد', 2, CAST(N'2016-11-30 15:13:34.173' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (206, N'6bb8f311-1b12-46a3-8497-2a38474be6dc', N'55', N'تهران مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (207, N'4f1a41c4-594c-4ebb-9c78-b093ae9d1b8f', N'56', N'گيلان', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (208, N'dca07382-9cb8-4561-a74e-4bd710251a3f', N'57', N'استان مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (209, N'cbf80c6d-eba4-4168-ba88-ce2ebe239483', N'58', N'استان بوشهر', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (210, N'c1c56ac3-5960-45d0-98c6-4e163fa43ead', N'59', N'گرگان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (211, N'5cc3434a-59f1-425c-80bc-5c53870854ce', N'61', N'استان لرستان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (212, N'73e3e333-2acf-4722-bb0b-83e2bf04fb96', N'62', N'ساري', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (213, N'21ffd625-4f7d-49a1-ac68-6649eb7faeaa', N'63', N'شيراز', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (214, N'886c7321-954e-4250-b779-71bd090ea8b4', N'64', N'استان يزد', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (215, N'e6cac1e3-bd5b-40c3-8bc4-1dd8d5507640', N'65', N'استان کرمان', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (218, N'6e5ee6e0-55e8-4dd4-a043-d2c35c144d95', N'68', N'کرج', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (219, N'7bcb20a2-f287-4bc2-9653-94ab67a5be93', N'69', N'استان گرگان', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (220, N'b0ee0e4f-0d89-4575-90fb-dd3cfbd7c488', N'71', N'شهرکرد', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (221, N'2dce554a-8272-4805-85f5-7e9a5f34dd5b', N'72', N'استان مازندران', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (222, N'e36e9e76-7427-470f-95b9-25a3963eaaa9', N'73', N'استان فارس', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (225, N'b8d54fe7-3584-4f02-9801-50ba84d73064', N'76', N'استان گيلان', 2, CAST(N'2016-11-30 15:13:34.193' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (227, N'7261c50b-23c7-40a1-9e71-3eb1cc125e7b', N'78', N'شهرستان هاي تهران', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (228, N'd140671e-f99d-4044-b984-851ef9fccadf', N'79', N'قزوين', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (229, N'42d92392-780b-47a1-8a33-1341252a5e11', N'81', N'استان چهار محال و بختياري', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (232, N'f1d08f21-4690-41b3-bdec-5f920c52ee74', N'84', N'بندرعباس', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (233, N'19935827-e134-4371-9171-b00891200bb1', N'85', N'زاهدان', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (234, N'd3c08b03-94cb-43d2-92bc-4ca7c5bf2104', N'86', N'سمنان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (235, N'12a1126e-24f2-44ab-9507-26611a6d0160', N'87', N'زنجان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (237, N'e5109647-b0c5-4587-a6da-587a15b29047', N'89', N'استان قزوين', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (238, N'ddc5677d-0fd6-4fe2-baff-7430389dfbc0', N'91', N'اردبيل', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (241, N'5695724b-9f54-45fa-9a95-bd7d6f67e652', N'94', N'استان هرمزگان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (242, N'3fa1a814-c237-429c-8e08-a558084ee817', N'95', N'استان سيستان و بلوچستان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (243, N'15df7003-a5cc-44e9-88e5-8c5e4230d44f', N'96', N'استان سمنان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (244, N'4a8e8504-7539-4db7-8978-c20fabb72894', N'97', N'استان زنجان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (245, N'7272f1f3-6df9-4616-b84d-bf25f5c55d0b', N'98', N'ايلام', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (249, N'7c8964a8-fdd3-4a1b-b7b5-b7d66ec3a87c', N'99', N'تهران جنوب', 2, CAST(N'2016-11-30 15:18:52.400' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCity] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] ON 

GO
INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'6b018379-cc17-4d3b-9ad8-aca7c679dbfe', N'ايران', 2, CAST(N'2016-11-19 00:52:44.863' AS DateTime), 2, CAST(N'2016-11-19 00:52:53.523' AS DateTime))
GO
INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'c0f6d287-00f8-41e5-a42d-0e2dacbcdf44', N'ترکيه', 2, CAST(N'2016-11-19 00:52:49.507' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.PlateType] ON 

GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'1a6c5365-44ae-4a6a-be2f-a09b4ce069fe', N'عادي', 2, CAST(N'2016-11-30 16:22:03.323' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'2f707462-df81-4bbf-8e39-02b44365297d', N'تاکسي', 2, CAST(N'2016-11-30 16:22:09.507' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (6, N'a4ca3dfc-50e9-4aab-88b9-0514e72c20e4', N'دولتي', 2, CAST(N'2016-11-30 16:22:51.040' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateType] OFF
GO
SET IDENTITY_INSERT [dbo].[System.Data] ON 

GO
INSERT [dbo].[System.Data] ([id], [viewId], [name], [value]) VALUES (3, N'dd010c7e-f228-467b-9eaa-42f4a94dad9c', N'DB-Version', N'95-09-11-01')
GO
SET IDENTITY_INSERT [dbo].[System.Data] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (2, N'6b5d6474-8382-47ba-9f2b-aa4edd7b9ee0', N'محمد', N'علويي', N'admin', N'123', CAST(N'2016-11-25 10:30:50.900' AS DateTime), 1)
GO
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (3, N'b30586e2-ca38-4b1f-9ae9-4a8551e1afa0', N'مرجان', N'قبادي', N'mj', N'123', CAST(N'2016-11-30 15:10:58.400' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarColor]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarColor] ON [dbo].[Base.CarColor]
(
	[color] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarFuel]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarFuel] ON [dbo].[Base.CarFuel]
(
	[fuel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarLevel]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarLevel] ON [dbo].[Base.CarLevel]
(
	[levelcar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarModel]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarModel] ON [dbo].[Base.CarSystem]
(
	[system] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarType]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarType] ON [dbo].[Base.CarType]
(
	[type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.PlateCity]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE NONCLUSTERED INDEX [IX_Base.PlateCity] ON [dbo].[Base.PlateCity]
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.PlateCountry]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.PlateCountry] ON [dbo].[Base.PlateCountry]
(
	[country] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.PlateType]    Script Date: 01/12/2016 06:41:42 ب.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.PlateType] ON [dbo].[Base.PlateType]
(
	[type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Car] ADD  CONSTRAINT [DF_Car_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Car] ADD  CONSTRAINT [DF_Car_capacity]  DEFAULT ((0)) FOR [capacity]
GO
ALTER TABLE [dbo].[CarOwner] ADD  CONSTRAINT [DF_CarOwner_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[LegalOwner] ADD  CONSTRAINT [DF_LegalOwner_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Owner] ADD  CONSTRAINT [DF_Owner_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Plate] ADD  CONSTRAINT [DF_Plate_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Tag] ADD  CONSTRAINT [DF_Tag_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Traffic] ADD  CONSTRAINT [DF_Traffic_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[UHF] ADD  CONSTRAINT [DF_UHF_viewId]  DEFAULT (newid()) FOR [viewId]
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
USE [master]
GO
ALTER DATABASE [GasStation] SET  READ_WRITE 
GO
