USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spTrafficRegisterByService]    Script Date: 22/03/2017 11:16:39 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  PROCEDURE [dbo].[spTrafficRegisterByService]
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
				(DATEDIFF (MINUTE, trafficDate, GETDATE ()) < @intervalTime)
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


/*
	UPDATE DB VERSION
*/

DECLARE @version	varchar(50) = '96-01-02-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO