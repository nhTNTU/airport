--Видалення аеропорту
CREATE PROC [DeleteAirPort]
	@AirPortID INT
AS
DELETE FROM [AirPort] 
	WHERE [AirPort].[airP_id] = @AirPortID;