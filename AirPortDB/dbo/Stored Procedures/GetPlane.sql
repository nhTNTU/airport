--Отримання інформації про літак
CREATE PROC [GetPlane]
	@PlaneID INT
AS
SELECT [pln_id], [pln_airc_id_FK], [pln_model], [pln_number]
FROM [dbo].[Plane]
WHERE [pln_id] = @PlaneID;