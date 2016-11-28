use GasStation
GO

ALTER TABLE [System.Data]
DROP COLUMN [version]
GO


/*
	Detete column tagId from Car Table
 */
ALTER TABLE [Car]
DROP CONSTRAINT FK_Car_Tag

ALTER TABLE [Car] 
DROP COLUMN tagId


/*
	 ADD:  Table [dbo].[CarTag]  
*/
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


/*
	Insert Column enable in User table
*/

ALTER TABLE [User]
ADD enable tinyint NOT NULL
GO


/*
	UPDATE DB VERSION
*/
DECLARE @version	varchar(50) = '95-09-05-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO