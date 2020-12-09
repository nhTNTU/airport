CREATE PROC [AircompanyUpdate]
	@AirсompanyName NVARCHAR (50),
	@AirсompanyPhone NVARCHAR (20),
	@AirсompanyAddress NVARCHAR (100),
	@AirсompanyID int
AS
UPDATE [dbo].[Aircompany]
	SET [airc_name] = @AirсompanyName
	, [airc_phone] = @AirсompanyPhone
	, [airc_adress] = @AirсompanyAddress
	WHERE [airc_id] = @AirсompanyID;