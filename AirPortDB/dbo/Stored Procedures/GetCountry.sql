CREATE PROC [GetCountry]
	@CountryID INT
AS
SELECT [cntr_id], [cntr_name]
FROM [dbo].[Country]
WHERE [cntr_id] = @CountryID;