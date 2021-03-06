USE [master]
GO
/****** Object:  Database [GasStation]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  User [admin]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarColor]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarFuel]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarLevel]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarSystem]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.CarType]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.GridHeader]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.PlateCountry]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Base.PlateType]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Car]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[CarOwner]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[CarTag]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[HC.Sexuality]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[LegalOwner]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Owner]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Plate]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[System.Data]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Tag]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[Traffic]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[UHF]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
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
INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'8b5d8b57-2c53-45df-ad6d-ffa74b16979f', N'پژو', 2, CAST(N'2016-12-04 22:49:32.157' AS DateTime), NULL, NULL)
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
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'24a22ab1-17c2-4208-ade3-57a06a6271e6', N'عادي', 2, CAST(N'2016-12-02 12:05:11.277' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'48d690e1-3024-4d70-a47c-854bddda36ce', N'تاکسي', 2, CAST(N'2016-12-02 12:05:16.683' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'91d2d573-c10b-4cb4-908d-5113ca9dc9f6', N'دولتي', 2, CAST(N'2016-12-02 12:05:23.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'c91abdf8-d69d-42aa-9113-8a6af85fab8e', N'معلولين', 2, CAST(N'2016-12-02 12:06:45.820' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'b3078074-c59f-4481-88cb-6becc5aeb0ee', N'موتورسيکلت', 2, CAST(N'2016-12-02 12:06:56.460' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateType] OFF
GO
SET IDENTITY_INSERT [dbo].[Car] ON 

GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'fb067de1-408f-4b88-b5fb-52bd7f83ad79', 3, 4, 5, 2, 7, 13, N'10', 1, 11, N'13', N'12', 2, CAST(N'2016-12-05 11:12:23.153' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'9a9d8774-152a-45a4-bdb5-0dfe4db070bb', 3, 4, 5, 2, 7, 14, N'12', 1, 100, N'212', N'112121', 2, CAST(N'2016-12-05 11:18:24.573' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'80468389-ff0d-47c7-9a42-4cd389a6d153', 3, 4, 5, 2, 7, 15, N'10', 1, 100, N'121', N'21', 2, CAST(N'2016-12-05 11:20:10.157' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'dada775a-64c6-4ad5-ab6b-62550bf9cc2b', 3, 4, 5, 2, 7, 16, N'12', 1, 45, N'43', N'44', 2, CAST(N'2016-12-05 11:22:30.900' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'99262aab-31c5-4b62-8429-4ed87e6593f3', 4, 5, 5, 2, 8, 17, N'45', 1, 2, N'24', N'23', 2, CAST(N'2016-12-05 11:31:09.800' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'545c6de9-aa00-49f2-bf96-42f9bd8ffdf5', 3, 4, 5, 2, 7, 18, N'12', 1, 21, N'11', N'25', 2, CAST(N'2016-12-05 11:35:55.450' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (15, N'60cb3d5f-c288-4df3-96ba-8333cb6ae29b', 3, 4, 5, 2, 7, 19, N'95', 1, 5, N'56565', N'56666', 2, CAST(N'2016-12-05 11:38:16.887' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Car] OFF
GO
SET IDENTITY_INSERT [dbo].[CarOwner] ON 

GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'c3b9e2e6-19d4-4104-b400-dd80d0629e96', 9, 10, 0, 2, CAST(N'2016-12-05 11:12:52.160' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'5da9dc25-577d-4e5e-9dcb-f0fc76cd6e7c', 10, 11, 0, 2, CAST(N'2016-12-05 11:18:24.590' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'5163cbe8-61c0-4e4b-8c98-57944303c3fb', 11, 12, 0, 2, CAST(N'2016-12-05 11:20:10.173' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'd7000a2a-8874-4ba6-a249-f35b8ea65f70', 12, 13, 0, 2, CAST(N'2016-12-05 11:22:30.913' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'6e053ae7-9876-41da-b9a2-50e04d056fd3', 13, 14, 0, 2, CAST(N'2016-12-05 11:31:09.813' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'f7e608fe-1fb1-4246-ac6a-846c81e97f42', 14, 15, 0, 2, CAST(N'2016-12-05 11:35:55.463' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (15, N'961d9018-254d-4269-9896-12a8f98c91c3', 15, 16, 0, 2, CAST(N'2016-12-05 11:38:16.907' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[CarOwner] OFF
GO
SET IDENTITY_INSERT [dbo].[CarTag] ON 

GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'56f441dd-aab4-4872-bfcf-532f768c8e1b', 12, 6, 2, CAST(N'2016-12-05' AS Date), NULL, NULL)
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'60cb5bb2-eeab-4b8d-b4f6-c3793568293f', 13, 7, 2, CAST(N'2016-12-05' AS Date), NULL, NULL)
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'17cac5bd-cdf3-40cd-b13a-e6a0bbfeb5e6', 14, 8, 2, CAST(N'2016-12-05' AS Date), NULL, NULL)
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'9d15a71d-35ec-4eca-997e-e4718708cdfc', 15, 9, 2, CAST(N'2016-12-05' AS Date), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[CarTag] OFF
GO
SET IDENTITY_INSERT [dbo].[HC.Sexuality] ON 

GO
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (1, N'85217f29-a579-4bbe-a590-5a4fd262d3fa', N'زن')
GO
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (2, N'0f56a913-e787-4929-a3bc-abf6105ea38e', N'مرد')
GO
SET IDENTITY_INSERT [dbo].[HC.Sexuality] OFF
GO
SET IDENTITY_INSERT [dbo].[Owner] ON 

GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (6, N'f3f56e68-bbe6-4e15-bf4c-5071d36017c0', N'4324260869', N'مرجان', N'قبادي فرد', NULL, N'قزوين', 1, N'02833346602', N'09193862018', N'قزوين', 2, CAST(N'2016-12-05 09:04:07.733' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'd0694234-1c10-4930-b6ea-de7d1342b289', N'4222222222', N'علي', N'قنبري', NULL, N'', 2, N'', N'09125647896', N'', 2, CAST(N'2016-12-05 11:12:08.113' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'2856e0f3-75d7-4c53-a5ae-79191302f91f', N'4236555555', N'علي', N'قنبري', NULL, N'', 2, N'', N'09124568978', N'', 2, CAST(N'2016-12-05 11:18:24.553' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'be4115d7-7a9b-49c5-be54-d8a9e1e334cd', N'4444444444', N'علي', N'قنبري', NULL, N'', 2, N'', N'09125648977', N'', 2, CAST(N'2016-12-05 11:20:09.927' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'8522fda5-fce4-44e1-8eec-674cb4dca0e8', N'4444444444', N'علي', N'قنبري', NULL, N'', 2, N'', N'09124567889', N'', 2, CAST(N'2016-12-05 11:22:30.890' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'c643ad1a-e926-4265-9950-835a30a9ebde', N'8888888888', N'فريبا', N'رجبي', NULL, N'', 1, N'', N'09124567889', N'', 2, CAST(N'2016-12-05 11:31:09.787' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (15, N'a1ca61b0-089b-4657-94cb-129aace92d2f', N'8574123666', N'اکبر', N'رحيمي', NULL, N'', 2, N'', N'09125647879', N'', 2, CAST(N'2016-12-05 11:35:55.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (16, N'0571ddef-f01e-4788-8892-3b6328da6490', N'8999999999', N'علي', N'فکري', NULL, N'', 2, N'', N'09125667879', N'', 2, CAST(N'2016-12-05 11:38:16.870' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Owner] OFF
GO
SET IDENTITY_INSERT [dbo].[Plate] ON 

GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'158c99db-aa48-4ae9-b01a-24224aceabac', 10, 197, N'12_ت_123_45', 2, CAST(N'2016-12-05 11:07:30.150' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'6264df7d-da7c-4795-8ed0-4a9f179f71a6', 10, 227, N'12_ل_121_78', 2, CAST(N'2016-12-05 11:12:03.507' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'87607474-4b10-41a8-b90e-581dbbe3969c', 10, 197, N'12_ل_123_45', 2, CAST(N'2016-12-05 11:18:24.540' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (15, N'c933bbd2-c50f-481c-afba-a8283ee578fe', 10, 197, N'45_غ_456_45', 2, CAST(N'2016-12-05 11:20:09.910' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (16, N'258627e8-ecf9-424c-b3fd-9e8b7ad49bbc', 10, 227, N'45_ل_152_78', 2, CAST(N'2016-12-05 11:22:30.703' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (17, N'3ad4ee6f-b396-4e6f-b6cd-ae2ac96359b5', 10, 227, N'45_ن_454_78', 2, CAST(N'2016-12-05 11:31:09.770' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (18, N'451f8fd2-98d6-42db-a7da-797dd91e31c4', 10, 245, N'45_ت_456_98', 2, CAST(N'2016-12-05 11:35:55.200' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (19, N'8b96475b-75bd-4b2f-ad8b-56222abc0c78', 10, 197, N'45_ت_554_45', 2, CAST(N'2016-12-05 11:38:16.853' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Plate] OFF
GO
SET IDENTITY_INSERT [dbo].[System.Data] ON 

GO
INSERT [dbo].[System.Data] ([id], [viewId], [name], [value]) VALUES (3, N'dd010c7e-f228-467b-9eaa-42f4a94dad9c', N'DB-Version', N'95-09-15-1')
GO
SET IDENTITY_INSERT [dbo].[System.Data] OFF
GO
SET IDENTITY_INSERT [dbo].[Tag] ON 

GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'73db2c90-2513-4e8f-b40d-a21ad15922c9', N'[53168804447d7aeb3680]', 2, CAST(N'2016-12-05 11:13:28.273' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'c43b3e63-bd8e-48a3-a98c-ae6d9cc4c0ba', N'[53168804447d7aeb3680]', 2, CAST(N'2016-12-05 11:18:28.270' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'0ee466e8-db04-49a9-b720-42c3ae7ea97c', N'[53168804447d7aeb3680]', 2, CAST(N'2016-12-05 11:20:10.183' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (6, N'4a5046c5-0737-4e58-b0ae-0abb8e52a662', N'[53168804447d7aeb3680]', 2, CAST(N'2016-12-05 11:22:30.927' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'd7e54968-7b82-4da6-ad06-37caf26f760f', N'[53168804447d7aeb3681]', 2, CAST(N'2016-12-05 11:31:09.823' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'93a9794f-5574-46b8-9bcc-b6357dc82317', N'[53168804447d7aeb3681]', 2, CAST(N'2016-12-05 11:35:55.477' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'382c8b37-83ad-4193-a863-f5fc7d76a578', N'[53168804447d7aeb3681]', 2, CAST(N'2016-12-05 11:38:16.917' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Tag] OFF
GO
SET IDENTITY_INSERT [dbo].[UHF] ON 

GO
INSERT [dbo].[UHF] ([id], [viewId], [IP], [Port], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'2cf20660-a678-48d2-9153-6fffc958e5da', N'127.0.0.1', 1470, 2, CAST(N'2016-03-12 00:00:00.000' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[UHF] OFF
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
/****** Object:  Index [IX_Base.CarColor]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarColor] ON [dbo].[Base.CarColor]
(
	[color] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarFuel]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarFuel] ON [dbo].[Base.CarFuel]
(
	[fuel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarLevel]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarLevel] ON [dbo].[Base.CarLevel]
(
	[levelcar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarModel]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarModel] ON [dbo].[Base.CarSystem]
(
	[system] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.CarType]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.CarType] ON [dbo].[Base.CarType]
(
	[type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.PlateCity]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE NONCLUSTERED INDEX [IX_Base.PlateCity] ON [dbo].[Base.PlateCity]
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.PlateCountry]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.PlateCountry] ON [dbo].[Base.PlateCountry]
(
	[country] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Base.PlateType]    Script Date: 05/12/2016 11:39:47 ق.ظ ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Base.PlateType] ON [dbo].[Base.PlateType]
(
	[type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LegalOwner] ADD  CONSTRAINT [DF_LegalOwner_viewId]  DEFAULT (newid()) FOR [viewId]
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
USE [master]
GO
ALTER DATABASE [GasStation] SET  READ_WRITE 
GO
