--Спиок аеропортів для зовнішнього ключа по місту
CREATE PROC [SelectRefAirPortListByCity]
	@AirPortCityID INT
AS
SELECT A.[airP_id] , A.[airP_name]
FROM [dbo].[AirPort] A
WHERE A.[airP_city_id_FK] = @AirPortCityID;