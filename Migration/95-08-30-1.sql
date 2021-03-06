USE GasStation
Go

EXEC sp_rename '[Base.CarColor].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.CarColor].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.CarFuel].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.CarFuel].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.CarLevel].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.CarLevel].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.CarModel].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.CarModel].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.CarType].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.CarType].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.PlateCity].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.PlateCity].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.PlateCountry].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.PlateCountry].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.PlateLetter].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.PlateLetter].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Base.PlateType].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Base.PlateType].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Car].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Car].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Owner].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Owner].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Plate].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Plate].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[RealOwner].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[RealOwner].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Tag].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Tag].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[Traffic].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[Traffic].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[UHF].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[UHF].updatedBy', 'updatedById', 'COLUMN'

EXEC sp_rename '[User].insertedBy', 'insertedById', 'COLUMN'
EXEC sp_rename '[User].updatedBy', 'updatedById', 'COLUMN'

ALTER TABLE [User]
ALTER COLUMN insertDate datetime 
GO

ALTER TABLE [User]
ADD CONSTRAINT DF_user_insertDate DEFAULT getDate() FOR insertDate
GO


/*
	UPDATE DB VERSION
*/
DECLARE @version	varchar(50) = '95-08-30-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO