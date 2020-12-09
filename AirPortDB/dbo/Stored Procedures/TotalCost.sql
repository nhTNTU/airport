--Підрахунок загальної вартості куплених квитків
CREATE PROCEDURE [TotalCost]
	@idBuyer INT
AS
SELECT
	SUM (CASE
			WHEN T.[tkt_class] = N'Економ' THEN F.[fl_priceEconom] 
			WHEN T.[tkt_class] = N'Бізнес' THEN F.[fl_priceBusiness] 
			WHEN T.[tkt_class] = N'Перший' THEN F.[fl_priceFirst]
			END
			)
FROM [dbo].[Flight] F
	INNER JOIN
	[dbo].[Ticket] T
	ON
		F.[fl_id] = T.[tkt_fl_id_FK]
	INNER JOIN
	[dbo].[Buyer] B
	ON
		T.[tkt_br_id_FK] = B.[br_id]
WHERE B.[br_id] = @idBuyer