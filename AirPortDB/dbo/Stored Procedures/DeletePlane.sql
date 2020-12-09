--Видалення інформації про літак
CREATE PROC [DeletePlane]
	@PlaneID INT
AS
DELETE FROM [dbo].[Plane] 
	WHERE [dbo].[Plane].[pln_id] = @PlaneID;