CREATE PROC [AircompanyDelete]
	@AirсompanyID int
AS
DELETE FROM [dbo].[Aircompany] WHERE [airc_id] = @AirсompanyID;