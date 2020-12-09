CREATE PROC [SelectRefPlaneList]
AS
SELECT P.[pln_id]
		, P.[pln_model] + ' : ' + P.[pln_number] + ' (' + A.[airc_name] + ')' AS [PlaneName]
FROM [dbo].[Plane] P
	INNER JOIN [dbo].[Aircompany] A
	ON P.[pln_airc_id_FK] = A.[airc_id]