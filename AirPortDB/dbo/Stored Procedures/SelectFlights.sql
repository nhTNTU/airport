--Список рейсів
CREATE PROC [SelectFlights]
	@BeginDate DATETIME = '1900-01-01 00:00:00',
	@EndDate DATETIME = '2050-01-01 00:00:00',
	@CountryID INT = 0,
	@CityID INT = 0,
	@AirPortID INT = 0
AS
SELECT F.[fl_id]
		, F.[fl_airc_id_FK] 
		, F.[fl_pln_id_FK] 
		, F.[fl_airP_id_FK] 
		, F.[fl_type] 
		, F.[fl_dateTimeStart] 
		, CONVERT(NVARCHAR, F.[fl_duration], 108) AS [Duration]
		, F.[fl_dateTimeArrival] 
		, F.[fl_priceEconom] 
		, F.[fl_priceBusiness] 
		, F.[fl_priceFirst] 
		, F.[fl_dateTimeStartGMT] 
		, F.[fl_dateTimeArrivalGMT] 
		, F.[fl_status] 
		, AC.[airc_name] 
		, P.[pln_model] 
		, AP.[airP_name] AS [AirPortName]
		, CI.[city_name] AS [CityName]
		, CO.[cntr_name] AS [CountryName]
FROM [dbo].[Flight] F
	INNER JOIN [dbo].[Aircompany] AC
	ON F.[fl_airc_id_FK] = AC.[airc_id]
	INNER JOIN [dbo].[Plane] P
	ON F.[fl_pln_id_FK] = P.[pln_id]
	INNER JOIN [dbo].[AirPort] AP
	ON F.[fl_airP_id_FK] = AP.[airP_id]
	INNER JOIN [dbo].[City] CI
	ON AP.[airP_city_id_FK] = CI.[city_id]
	INNER JOIN [dbo].[Country] CO
	ON CI.[city_cntr_id_FK] = CO.[cntr_id]
WHERE 
		(
			((F.[fl_dateTimeStart] BETWEEN @BeginDate AND @EndDate)
	AND F.[fl_type] = N'Вихідний')
	OR
	((F.[fl_dateTimeArrival] BETWEEN @BeginDate AND @EndDate)
	AND F.[fl_type] = N'Вхідний')
		)
	AND
	(
			(CO.[cntr_id] = @CountryID) OR (@CountryID = 0)
		)
	AND
	(
			(CI.[city_id] = @CityID) OR (@CityID = 0)
		)
	AND
	(
			(AP.[airP_id] = @AirPortID) OR (@AirPortID = 0)
		);