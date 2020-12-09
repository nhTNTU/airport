--Видалення даних про рейс
CREATE PROC [DeleteFlight]
	@FlightID INT
AS
BEGIN TRANSACTION;
DELETE FROM [dbo].[Flight]
		WHERE [dbo].[Flight].[fl_id] = @FlightID;
COMMIT;