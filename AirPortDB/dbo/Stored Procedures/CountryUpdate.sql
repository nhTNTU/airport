CREATE PROC [CountryUpdate]
	@CountryName NVARCHAR (50),
	@CountryID INT
AS
UPDATE [dbo].[Country] 
	SET [cntr_name] = @CountryName
	WHERE [cntr_id] = @CountryID;