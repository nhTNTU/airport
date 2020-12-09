--Виведення інформації про Авіакомпанії і літаків, що їм належать
CREATE PROCEDURE [AircompWithPlanes]
AS

SELECT
	AC.[airc_name] AS [Авіакомпанія],
	P.[pln_model] AS [Літак],
	P.[pln_number] AS [Бортовий номер]
FROM [dbo].[Aircompany] AC
	INNER JOIN
	[dbo].[Plane] P
	ON 
		AC.[airc_id] = P.[pln_airc_id_FK]
GROUP BY
		AC.[airc_name] ,
		P.[pln_model] ,
		P.[pln_number];

SELECT
	[airc_name] AS [Авіакомпанія],
	[airc_phone] AS [Телефон],
	[airc_adress] AS [Адреса офісу]
FROM [dbo].[Aircompany]