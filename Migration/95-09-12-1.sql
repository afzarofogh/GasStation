USE [GasStation]
GO
/****** Object:  Table [dbo].[HC.Sexuality]    Script Date: 02/12/2016 04:41:28 ب.ظ ******/
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
SET IDENTITY_INSERT [dbo].[HC.Sexuality] ON 

GO
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (1, N'85217f29-a579-4bbe-a590-5a4fd262d3fa', N'زن')
GO
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (2, N'0f56a913-e787-4929-a3bc-abf6105ea38e', N'مرد')
GO
SET IDENTITY_INSERT [dbo].[HC.Sexuality] OFF
GO
/*
	UPDATE DB VERSION
*/

DECLARE @version	varchar(50) = '95-09-12-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO