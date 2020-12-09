--Збережувані процедури для інтерфейсу
CREATE PROCEDURE [AircompanySelect]
AS
SELECT [airc_id], [airc_name], [airc_phone], [airc_adress]
FROM [dbo].[Aircompany]