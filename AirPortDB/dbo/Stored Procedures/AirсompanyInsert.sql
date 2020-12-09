CREATE PROC [AircompanyInsert]
	@AirсompanyName NVARCHAR (50),
	@AirсompanyPhone NVARCHAR (20),
	@AirсompanyAddress NVARCHAR (100)
AS
INSERT INTO [dbo].[Aircompany]
	([airc_name], [airc_phone], [airc_adress])
VALUES
	(@AirсompanyName, @AirсompanyPhone, @AirсompanyAddress);