--Оновлення аеропорту
CREATE PROC [UpdateAirPort]
	@AirPortID INT,
	@AirPortName NVARCHAR (50),
	@AirPortCityID INT
AS
BEGIN TRANSACTION;
UPDATE [dbo].[AirPort] 
		SET
			[airP_name] = @AirPortName,
			[airP_city_id_FK] = @AirPortCityID
		WHERE
			[dbo].[AirPort].[airP_id] = @AirPortID;
COMMIT;