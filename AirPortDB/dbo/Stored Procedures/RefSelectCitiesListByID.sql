--Список Міст по ID країни (для зовнішнього ключа)
CREATE PROC [RefSelectCitiesListByID]
	@CountryID INT
AS
SELECT [city_id], [city_name]
FROM [dbo].[City]
WHERE [city_cntr_id_FK] = @CountryID;