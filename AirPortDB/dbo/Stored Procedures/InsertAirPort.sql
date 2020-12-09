--Вставка нового аеропорту
CREATE PROC [InsertAirPort]
	@AirPortName NVARCHAR (50),
	@AirPortCityID INT
AS
BEGIN TRANSACTION;
INSERT INTO [dbo].[AirPort]
	([airP_name], [airP_city_id_FK])
VALUES
	(
		@AirPortName, @AirPortCityID
		);
COMMIT;