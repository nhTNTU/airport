CREATE PROC [CityDelete]
	@CityID INT
AS
DELETE FROM [dbo].[City] WHERE [city_id] = @CityID;