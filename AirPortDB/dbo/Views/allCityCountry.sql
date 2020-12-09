--Представлення, що показує міста і країни
CREATE VIEW [allCityCountry]
AS
SELECT 
	S.[city_name] AS [Місто],
	[city_population] AS [Населення],
	[city_signGMT] AS [Зн],
	CONVERT (NVARCHAR, [city_GMT], 8) AS [GMT],
	C.[cntr_name] AS [Країна]
FROM [dbo].[City] S
INNER JOIN [dbo].Country C
ON C.[cntr_id] = S.[city_cntr_id_FK]