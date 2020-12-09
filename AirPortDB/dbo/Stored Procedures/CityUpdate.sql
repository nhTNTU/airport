CREATE PROC [CityUpdate]
	@CityID INT,
	@CityCountryID INT,
	@CityName NVARCHAR (50),
	@CityPopulation BIGINT,
	@CityGMT DATETIME,
	@CitySignGMT NVARCHAR (1)
AS
UPDATE [dbo].[City]  SET [city_cntr_id_FK] = @CityCountryID
	,[city_name] = @CityName
	,[city_population] = @CityPopulation
	,[city_GMT] = @CityGMT
	,[city_signGMT] = @CitySignGMT
	WHERE [city_id] = @CityID;