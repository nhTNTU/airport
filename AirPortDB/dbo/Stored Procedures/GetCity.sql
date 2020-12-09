CREATE PROC [GetCity]
	@CityID INT
AS
SELECT [city_id]
	, [city_cntr_id_FK]
	, [city_name] 
	, [city_population]
	, [city_GMT]
	, [city_signGMT]
FROM [dbo].[City]
WHERE [city_id] = @CityID;