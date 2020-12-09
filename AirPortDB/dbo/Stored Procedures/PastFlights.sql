--Звіт про переміщення літаків
CREATE PROCEDURE [PastFlights]
	@PastDate DATETIME
AS

SELECT
	AC.[airc_name] AS [Авіакомпанія],
	C.[city_name] AS [Місто],
	AP.[airP_name] AS [Аеропорт],
	--[DateTimeStartGMT] AS [Виліт] = 
	CONVERT (NVARCHAR, [fl_dateTimeStartGMT], 13) AS [Виліт],
	CONVERT (NVARCHAR, [fl_dateTimeArrivalGMT], 13) AS [Прибуття],
	[fl_type] AS [Тип рейсу],
	[fl_status] AS [Статус],
	[Вид рейсу] = (
	CASE
		WHEN C.[city_cntr_id_FK] = 1 THEN N'Внутрішній'
		ELSE N'Міжнародний'
	END
	)
FROM [dbo].[Flight] F
	INNER JOIN
	[dbo].[Aircompany] AC
	ON
		AC.[airc_id] = F.[fl_airc_id_FK]
	INNER JOIN
	[dbo].[AirPort] AP
	ON
		AP.[airP_id] = F.[fl_airP_id_FK]
	INNER JOIN
	[dbo].[City] C
	ON		
		AP.[airP_city_id_FK] = C.[city_id]
GROUP BY
	C.[city_cntr_id_FK], F.[fl_type], F.[fl_dateTimeStartGMT], F.[fl_dateTimeArrivalGMT],
	C.[city_name], AC.[airc_name], AP.[airP_name], F.[fl_status]
HAVING 
	F.[fl_dateTimeStartGMT] <= GETDATE () AND
	F.[fl_dateTimeArrivalGMT] >= @PastDate