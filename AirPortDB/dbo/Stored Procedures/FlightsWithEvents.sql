--Виведення інформації про події, пов'язані з літаком на рейсі
CREATE PROCEDURE [FlightsWithEvents]
AS

SELECT
	F.[fl_id] AS [ID],
	AC.[airc_name] AS [Авіакомпанія],
	C.[city_name] AS [Місто],
	AP.[airP_name] AS [Аеропорт],
	F.[fl_type] AS [Тип рейсу],
	P.[pln_model] AS [Літак],
	P.[pln_number] AS [Бортовий номер],
	CONVERT (NVARCHAR, F.[fl_dateTimeStart], 13) AS [Виліт],
	CONVERT (NVARCHAR, ES.[e_dateTimeEvent], 13) AS [Вилетів],
	CONVERT (NVARCHAR, EA.[e_dateTimeEvent], 13) AS [Прибув],
	CONVERT (NVARCHAR, [fl_dateTimeArrival], 13) AS [Прибуття],
	[Вид рейсу] = (
	CASE
		WHEN [city_cntr_id_FK] = 1 THEN N'Внутрішній'
		ELSE N'Міжнародний'
	END
	),
	[fl_status] AS [Статус]
FROM [dbo].[Flight] F
	INNER JOIN
	[dbo].[Aircompany] AC
	ON 
		F.[fl_airc_id_FK] = AC.[airc_id]
	INNER JOIN
	[dbo].[AirPort] AP
	ON 
		F.[fl_airP_id_FK] = AP.[airP_id]
	INNER JOIN
	[dbo].[City] C
	ON
		AP.[airP_city_id_FK] = C.[city_id]
	LEFT OUTER JOIN
	[dbo].[Event] ES
	ON 
		F.[fl_id] = ES.[e_fl_id_FK] AND ES.[e_eventType] = N'Вилетів'
	LEFT OUTER JOIN
	[dbo].[Event] EA
	ON
		F.[fl_id] = EA.[e_fl_id_FK] AND EA.[e_eventType] = N'Прибув'
	INNER JOIN
	[dbo].[Plane] P
	ON 
		F.[fl_pln_id_FK] = P.[pln_id]