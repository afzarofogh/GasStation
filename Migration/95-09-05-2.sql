USE GasStation

/*
	UPDATE DB VERSION
*/
DECLARE @version	varchar(50) = '95-09-05-1';
DECLARE @pversion	varchar(50) = 'version-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value], [version]) VALUES ('DB-Version', @version, @pversion)
	END
GO
