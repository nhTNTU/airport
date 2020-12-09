--Отримання повної інформації про один рейс
CREATE PROC [GetFlight]
	@FlightID INT
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
FROM [dbo].[Flight] F
WHERE F.[fl_id] = @FlightID;