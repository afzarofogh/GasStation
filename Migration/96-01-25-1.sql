USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetCarSearchByNationalcode]    Script Date: 4/14/2017 2:10:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*  spGetCarSearchByNationalcode  */

CREATE PROCEDURE [dbo].[spGetCarSearchByNationalcode]
	@nationalCode varchar(10)
AS
BEGIN
	SELECT  
			[Base.CarType].type as carType,
			[Base.CarColor].color, 
			plate,
			[Base.PlateCity].city,	
			[Base.PlateType].type as platetype, 
			Tag.tag

	FROM 
	Plate

		inner join Car				ON Car.plateId = Plate.id	
		inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		inner join CarOwner			ON CarOwner.carId = Car.id
		inner join Owner			ON Owner.id = CarOwner.ownerId
		inner join CarTag			ON CarTag.carId = Car.id
		inner join Tag				ON Tag.id = CarTag.tagId		

		WHERE nationalCode = @nationalCode
		GROUP BY [Base.CarType].type ,[Base.CarColor].color, plate,[Base.PlateCity].city, [Base.PlateType].type , Tag.tag
END

/****** Object:  StoredProcedure [dbo].[spGetCarSearchByPlate]    Script Date: 4/14/2017 2:10:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description: Get Report Info car' Owner by plate number
-- =============================================
CREATE PROCEDURE [dbo].[spGetCarSearchByPlate]
	@plate varchar(50)
AS
BEGIN
	SELECT  
			[Base.CarType].type as carType,
			[Base.CarColor].color, 
			plate,
			[Base.PlateCity].city,	
			[Base.PlateType].type as platetype, 
			Tag.tag

	FROM 
		Plate

			inner join Car				ON Car.plateId = Plate.id	
			inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
			inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
			inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
			inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
			inner join CarOwner			ON CarOwner.carId = Car.id
			inner join [Owner]			ON [Owner].id = CarOwner.ownerId
			inner join CarTag			ON CarTag.carId = Car.id
			inner join Tag				ON Tag.id = CarTag.tagId		

			WHERE plate = @plate
			GROUP BY [Base.CarType].type, [Base.CarColor].color, plate,[Base.PlateCity].city, [Base.PlateType].type, Tag.tag
END

GO
/****** Object:  StoredProcedure [dbo].[spGetOwnerSearchByPlate]    Script Date: 4/14/2017 2:12:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Owner Search By Plate
-- =============================================
CREATE PROCEDURE [dbo].[spGetOwnerSearchByPlate]
	@plate varchar(50)
AS
BEGIN	

SELECT  
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		[Owner].birthdate,
		[Owner].birthdatelocal,
		[Owner].gen,
		[Owner].phone,
		[Owner].mobile,
		[Owner].address,
		[Owner].insertedById,
		[Owner].insertDate,
		[Owner].updatedById,
		[Owner].updateDate		

	FROM 
		Plate

		INNER JOIN Car				ON Car.plateId = Plate.id	
		INNER JOIN [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		INNER JOIN [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		INNER JOIN [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		INNER JOIN [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		INNER JOIN CarOwner			ON CarOwner.carId = Car.id
		INNER JOIN [Owner]			ON [Owner].id = CarOwner.ownerId
		INNER JOIN CarTag			ON CarTag.carId = Car.id
		INNER JOIN Tag				ON Tag.id = CarTag.tagId
		INNER JOIN Traffic			ON Traffic.tagId = Tag.id

		WHERE 		 plate = @plate
			
		GROUP BY	[Owner].id,
					[Owner].name,
					[Owner].lastname, 
					[Owner].nationalCode, 
					[Owner].mobile,
					[Owner].birthdate,
					[Owner].birthdatelocal,
					[Owner].gen,
					[Owner].phone,
					[Owner].mobile,
					[Owner].address,
					[Owner].insertedById,
					[Owner].insertDate,
					[Owner].updatedById,
					[Owner].updateDate

	
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByNationalcode]    Script Date: 4/14/2017 2:14:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Report Traffic By Nationalcode
-- =============================================

CREATE PROCEDURE [dbo].[spGetReportTrafficByNationalcode] 
	@startDate as datetime,
	@endDate	as datetime,
	@nationalcode as varchar(10)
AS
BEGIN

	SET NOCOUNT ON;
	SELECT 
		dbo.Owner.name, 
		dbo.Owner.lastname,
		dbo.Owner.mobile,
		dbo.Plate.plate,		
		dbo.Traffic.trafficDate

		FROM

		dbo.Traffic

		inner join dbo.Tag			on dbo.Tag.id			= dbo.Traffic.tagId 
		inner join dbo.CarTag		on dbo.CarTag.tagId		=  dbo.Traffic.tagId
		inner join dbo.Car			on dbo.Car.id			= dbo.CarTag.carId
		inner join dbo.Plate		on dbo.Plate.id			= dbo.Car.plateId
		inner join dbo.CarOwner		on dbo.CarOwner.carId	= dbo.Car.id
		inner join dbo.Owner		on dbo.Owner.id			= dbo.CarOwner.ownerId

		 WHERE 
			dbo.Traffic.trafficDate BETWEEN @startDate AND @endDate		
			AND nationalCode =  @nationalcode
END

GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByPlate]    Script Date: 4/14/2017 2:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Report Traffic By Plate
-- =============================================

CREATE PROCEDURE [dbo].[spGetReportTrafficByPlate] 
	@startDate	as datetime,
	@endDate	as datetime,
	@plate		as varchar(50)
AS
BEGIN

	SET NOCOUNT ON;
	SELECT 
		dbo.Owner.name, 
		dbo.Owner.lastname,
		dbo.Owner.mobile,
		dbo.Plate.plate,		
		dbo.Traffic.trafficDate

		FROM

		dbo.Traffic

		inner join dbo.Tag			on dbo.Tag.id			= dbo.Traffic.tagId 
		inner join dbo.CarTag		on dbo.CarTag.tagId		=  dbo.Traffic.tagId
		inner join dbo.Car			on dbo.Car.id			= dbo.CarTag.carId
		inner join dbo.Plate		on dbo.Plate.id			= dbo.Car.plateId
		inner join dbo.CarOwner		on dbo.CarOwner.carId	= dbo.Car.id
		inner join dbo.Owner		on dbo.Owner.id			= dbo.CarOwner.ownerId

		 WHERE 
			dbo.Traffic.trafficDate BETWEEN @startDate AND @endDate		
			AND plate =  @plate
END



GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByNationalcode]    Script Date: 4/14/2017 2:15:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic count By date and nationalcode
-- =============================================
CREATE PROCEDURE [dbo].[spGetReportTrafficCountByNationalcode]
	@startDate datetime,
	@endDate datetime,
	@nationalcode varchar(10)
AS
BEGIN	

SELECT  
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		COUNT(*) as total

	FROM 
		Plate

		INNER JOIN Car				ON Car.plateId = Plate.id	
		INNER JOIN [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		INNER JOIN [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		INNER JOIN [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		INNER JOIN [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		INNER JOIN CarOwner			ON CarOwner.carId = Car.id
		INNER JOIN [Owner]			ON [Owner].id = CarOwner.ownerId
		INNER JOIN CarTag			ON CarTag.carId = Car.id
		INNER JOIN Tag				ON Tag.id = CarTag.tagId
		INNER JOIN Traffic			ON Traffic.tagId = Tag.id

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN  @startDate AND  @endDate)
			AND nationalCode = @nationalcode 
			
		GROUP BY [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate

	
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByPlate]    Script Date: 4/14/2017 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic count By date and plate
-- =============================================
ALTER PROCEDURE [dbo].[spGetReportTrafficCountByPlate]
	@startDate datetime,
	@endDate datetime,
	@plate varchar(50)
AS
BEGIN	

SELECT  
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		COUNT(*) as total

	FROM 
		Plate

		INNER JOIN Car				ON Car.plateId = Plate.id	
		INNER JOIN [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		INNER JOIN [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		INNER JOIN [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		INNER JOIN [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		INNER JOIN CarOwner			ON CarOwner.carId = Car.id
		INNER JOIN [Owner]			ON [Owner].id = CarOwner.ownerId
		INNER JOIN CarTag			ON CarTag.carId = Car.id
		INNER JOIN Tag				ON Tag.id = CarTag.tagId
		INNER JOIN Traffic			ON Traffic.tagId = Tag.id

		WHERE 	
			
			dbo.Traffic.trafficDate BETWEEN  @startDate AND  @endDate
			AND plate = @plate 
			
		GROUP BY [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate
	
END

GO
/****** Object:  StoredProcedure [dbo].[spGetTrafficSearchByNationalcode]    Script Date: 4/14/2017 2:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Report Traffic by nationalcode
-- =============================================
ALTER PROCEDURE [dbo].[spGetTrafficSearchByNationalcode]
	@nationalCode varchar(10)
AS
BEGIN
	SELECT  plate,Traffic.trafficDate 

	FROM 
		Plate

			inner join Car				ON Car.plateId = Plate.id	
			inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
			inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
			inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
			inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
			inner join CarOwner			ON CarOwner.carId = Car.id
			inner join [Owner]			ON [Owner].id = CarOwner.ownerId
			inner join CarTag			ON CarTag.carId = Car.id
			inner join Tag				ON Tag.id = CarTag.tagId
			inner join Traffic			ON Traffic.tagId = Tag.id

			WHERE nationalCode = @nationalCode
			GROUP BY plate, Traffic.trafficDate
END


GO
/****** Object:  StoredProcedure [dbo].[spGetTrafficSerachByPlate]    Script Date: 4/14/2017 2:17:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Search Traffic by Plate
-- =============================================
CREATE PROCEDURE [dbo].[spGetTrafficSerachByPlate]
	@plate varchar(50)
AS
BEGIN
	SELECT  plate,Traffic.trafficDate 

	FROM 
		Plate

		inner join Car				ON Car.plateId = Plate.id	
		inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		inner join CarOwner			ON CarOwner.carId = Car.id
		inner join [Owner]			ON [Owner].id = CarOwner.ownerId
		inner join CarTag			ON CarTag.carId = Car.id
		inner join Tag				ON Tag.id = CarTag.tagId
		inner join Traffic			ON Traffic.tagId = Tag.id

		WHERE plate = @plate
		GROUP BY plate, Traffic.trafficDate
END

/*
	UPDATE DB VERSION
*/
DECLARE @version	varchar(50) = '96-01-25-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO