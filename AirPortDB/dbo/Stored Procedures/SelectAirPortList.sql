--Аеропорти
CREATE PROC [SelectAirPortList]
AS
SELECT A.[airP_id] 
	, A.[airP_name] 
	, CI.[city_name]
	, CO.[cntr_name]
FROM [dbo].[AirPort] A
	INNER JOIN [dbo].[City] CI
	ON A.[airP_city_id_FK] = CI.[city_id]
	INNER JOIN [dbo].[Country] CO
	ON CI.[city_cntr_id_FK] = CO.[cntr_id];