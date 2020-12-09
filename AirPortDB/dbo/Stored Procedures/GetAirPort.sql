--Аеропорт інформація за номером
CREATE PROC [GetAirPort]
	@AirPortID INT
AS
SELECT [airP_id], [airP_city_id_FK], [airP_name]
FROM [dbo].[AirPort]
WHERE [airP_id] = @AirPortID;