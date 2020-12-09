--Оновлення інформації про літак
CREATE PROC [UpdatePlane]
	@PlaneID INT,
	@PlaneAircompanyID INT,
	@PlaneModel NVARCHAR (20),
	@PlaneNumber NVARCHAR (50)
AS
UPDATE [Plane] 
	SET
		[pln_airc_id_FK] = @PlaneAircompanyID,
		[pln_model] = @PlaneModel,
		[pln_number] = @PlaneNumber
	WHERE [Plane].[pln_id] = @PlaneID;