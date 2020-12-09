--Авіакомпанії з літаками


--Виведення інформації про покупців:
CREATE VIEW [Buy]
AS
SELECT
	B.[br_lastName] AS [Прізвище],
	B.[br_firstName] AS [Ім'я],
	B.[br_phone] AS [Телефон],
	B.[br_altPhone] AS [Альт. тел.],
	B.[br_timeToConnect] AS [Час д/зв'язку],
	B.[br_deliveryAdress] AS [Адреса доставки],
	[CountOfTickets] = (
	
	SELECT 
		COUNT ([tkt_id])
	FROM [dbo].[Ticket] 
	WHERE [br_id] = B.[br_id] 
	
	),
	[Стоимость] = (
	
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