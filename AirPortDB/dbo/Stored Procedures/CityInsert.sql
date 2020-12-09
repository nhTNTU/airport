CREATE PROC [CityInsert]
	@CityCountryID INT,
	@CityName NVARCHAR (50),
	@CityPopulation BIGINT,
	@CityGMT DATETIME,
	@CitySignGMT NVARCHAR (1)
AS
INSERT INTO [dbo].[City]
	([city_cntr_id_FK]
	,[city_name]
	,[city_population]
	,[city_GMT]
	,[city_signGMT] )
VALUES
	( @CityCountryID
	, @CityName
	, @CityPopulation
	, @CityGMT
	, @CitySignGMT);