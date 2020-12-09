--Оновлення даних про рейс
CREATE PROC [UpdateFlight]
	@FlightID INT,
	@FlightAircompanyID INT,
	@FlightPlaneID INT,
	@FlightAirPortID INT,
	@FlightType NVARCHAR (20),
	@FlightDateTimeStart DATETIME,
	@FlightDuration DATETIME,
	@FlightPriceEconom MONEY,
	@FlightPriceBusiness MONEY,
	@FlightPriceFirst MONEY
AS
BEGIN TRANSACTION;
IF (@FlightDuration NOT BETWEEN '1900-01-01 00:00:00' AND '1900-02-01 00:00:00')
	BEGIN
	RAISERROR (N'Літак не може летіти більше доби', 8, 10);
	ROLLBACK TRANSACTION;
END
UPDATE [dbo].[Flight] 
		SET
			[fl_airc_id_FK] = @FlightAircompanyID,
			[fl_pln_id_FK] = @FlightPlaneID,
			[fl_airP_id_FK] = @FlightAirPortID,
			[fl_type] = @FlightType,
			[fl_dateTimeStart] = @FlightDateTimeStart,
			[fl_duration] = @FlightDuration,
			[fl_priceEconom] = @FlightPriceEconom,
			[fl_priceBusiness] = @FlightPriceBusiness,
			[fl_priceFirst] = @FlightPriceFirst 
		WHERE [dbo].[Flight].[fl_id] = @FlightID;
COMMIT;