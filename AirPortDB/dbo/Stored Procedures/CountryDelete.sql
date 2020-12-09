CREATE PROC [CountryDelete]
	@CountryID INT
AS
DELETE FROM [dbo].[Country] 
	WHERE [cntr_id] = @CountryID;