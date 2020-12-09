--Список авіакомпаній для зовнішнього ключа
CREATE PROC [SelectRefAircompaniesList]
AS
SELECT [airc_id], [airc_name]
FROM [dbo].[Aircompany]