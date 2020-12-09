--Список країн для фільтрів або зовнішнього ключа
CREATE PROC [RefCountriesSelect]
AS
SELECT [cntr_id], [cntr_name]
FROM [dbo].[Country] ;