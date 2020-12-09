--Місто
CREATE PROC [SelectCitiesList]
AS
SELECT CI.[city_id] 
	, CO.[cntr_name]
	, CI.[city_name]
	, CI.[city_cntr_id_FK] 	--Країни видалити
	, [city_GMT]
	, [city_signGMT]
FROM [dbo].[City] CI
	INNER JOIN [dbo].[Country] CO
	ON CI.[city_cntr_id_FK] = CO.[cntr_id]