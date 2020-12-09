--exec [AirCompanySelect] ;



CREATE PROC [CountryInsert]
	@CountryName NVARCHAR (50)
AS
INSERT INTO [dbo].[Country]
	([cntr_name] )
VALUES
	(@CountryName);