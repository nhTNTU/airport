--Вставка рейсу
CREATE PROC [InsertFlight]
	@FlightAircompanyID INT,
	@FlightPlaneID INT,
	@FlightAirPortID INT,
	@FlightType NVARCHAR (20),
	@FlightDateTimeStart DATETIME,
	@FlightDuration DATETIME,
	@FlightNumOfFlights INT,
	@FlightPeriodicity DATETIME,
	@FlightPriceEconom MONEY,
	@FlightPriceBusiness MONEY,
	@FlightPriceFirst MONEY
AS
BEGIN TRANSACTION;
IF (@FlightDuration NOT BETWEEN '1900-01-01 00:00:00' AND '1900-02-01 00:00:00')
	BEGIN
	RAISERROR (N'Літак не може літати більше доби', 8, 10);
	ROLLBACK TRANSACTION;
END
IF (@FlightPeriodicity NOT BETWEEN '1900-01-01 00:00:00' AND '1900-30-01 00:00:00')
	BEGIN
	RAISERROR (N'Перводичні рейси не можуть бути рідше одного разу в місяць', 8, 11)
	ROLLBACK TRANSACTION;
END
IF (@FlightNumOfFlights < 1)
	BEGIN
	RAISERROR (N'При додавані запису повинно бути не менце одного рейсу', 8, 12);
	ROLLBACK TRANSACTION;
END
INSERT INTO [dbo].[Flight]
	([fl_airc_id_FK]
	,[fl_pln_id_FK]
	,[fl_airP_id_FK]
	,[fl_type]
	,[fl_dateTimeStart]
	,[fl_duration]
	,[fl_numOfFlights]
	,[fl_periodicity]
	,[fl_priceEconom]
	,[fl_priceBusiness]
	,[fl_priceFirst]
	)
VALUES
	(@FlightAircompanyID 
		, @FlightPlaneID 
		, @FlightAirPortID 
		, @FlightType 
		, @FlightDateTimeStart
		, @FlightDuration
		, @FlightNumOfFlights 
		, @FlightPeriodicity
		, @FlightPriceEconom
		, @FlightPriceBusiness
		, @FlightPriceFirst
	);
COMMIT;