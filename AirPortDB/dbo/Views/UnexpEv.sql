--Виведення непередбачуваних подій, пов'язаних з літаком
CREATE VIEW [UnexpEv]
AS
SELECT
	F.[fl_id] AS [ID],
	AC.[airc_name] AS [Авіакомпанія],
	P.[pln_model] AS [Літак],
	P.[pln_number] AS [Бортовий номер],
	C.[city_name] AS [Місто],
	AP.[airP_name] AS [Аеропорт],
	CONVERT (NVARCHAR, F.[fl_dateTimeStart], 13) AS [Виліт],
	CONVERT (NVARCHAR, F.[fl_dateTimeArrival], 13) AS [Прибутя],
	[uE_eventType] AS [Подія],
	F.[fl_status] AS [Статус],
	CONVERT (NVARCHAR, UE.[uE_dateTimeEvent], 13) AS [Час події],
	CONVERT (NVARCHAR, UE.[uE_Duration], 13) AS [Тривалість],
	UE.[ue_reason] AS [Причина]
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
	INNER JOIN 
		[dbo].[Plane] P
	ON
		F.[fl_pln_id_FK] = P.[pln_id] 
	INNER JOIN
		[dbo].[UnexpectedEvent] UE
	ON
		F.[fl_id] = UE.[uE_fl_id_FK] 
GROUP BY
	AC.[airc_name], P.[pln_id], UE.[uE_dateTimeEvent], F.[fl_id], P.[pln_model], P.[pln_number],
	C.[city_name], AP.[airP_name], F.[fl_type], F.[fl_dateTimeStart], F.[fl_dateTimeArrival], UE.[uE_eventType],
	F.[fl_status], UE.[uE_dateTimeEvent], UE.[uE_Duration], UE.[ue_reason]