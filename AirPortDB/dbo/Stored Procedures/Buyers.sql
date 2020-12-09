--Виведення інформації про покупців
CREATE PROCEDURE [Buyers]

AS

SELECT
	B.[br_lastName] AS [Фамилия],
	B.[br_firstName] AS [Имя],
	B.[br_phone] AS [Телефон],
	B.[br_altPhone] AS [Альт. тел.],
	B.[br_timeToConnect] AS [Время д/связи],
	B.[br_deliveryAdress] AS [Адрес доставки],
	[CountOfTickets] = (
	
	SELECT
		COUNT ([tkt_id])
	FROM [dbo].[Ticket]
	WHERE [br_id] = B.[br_id] 
	
	),
	[Вартість] = (
	
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
		[dbo].[Buyer] Bu
		ON
		T.[tkt_br_id_FK] = Bu.[br_id]
	WHERE Bu.[br_id] = B.[br_id]
	
	),

	[К оплате] = (
	
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
		[dbo].[Buyer] Bu
		ON
		T.[tkt_br_id_FK] = Bu.[br_id]
	WHERE Bu.[br_id] = B.[br_id]
	
	) * (1 + Pay.[pay_addCost] )
FROM [dbo].[Buyer] B
	INNER JOIN
	[dbo].[Payment] Pay
	ON
		B.[br_pay_id_FK] = Pay.[pay_id]