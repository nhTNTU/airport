--Добавлення інформації про літак
CREATE PROC [InsertPlane]
	@PlaneAircompanyID INT,
	@PlaneModel NVARCHAR (20),
	@PlaneNumber NVARCHAR (50)
AS
INSERT INTO [dbo].[Plane]
	([pln_airc_id_FK]
	,[pln_model]
	,[pln_number]
	)
VALUES
	(@PlaneAircompanyID
		, @PlaneModel
		, @PlaneNumber
	)