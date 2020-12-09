--Виведення інформації про білети, які купила визначна людина
CREATE PROCEDURE [Passeng]
@LastName NVARCHAR (50),
@FirstName NVARCHAR (50)
AS

SELECT
	P.[pass_lastName] AS [Прізвище],
	P.[pass_firstName] AS [Ім'я],
	CONVERT (NVARCHAR, P.[pass_birthDate], 13) AS [Дата народження],
	P.[pass_gender] AS [Стать],
	D.[dT_name] AS [Документ],
	P.[pass_docNumber] AS [Номер документа],
	B.[br_lastName] AS [Прізвище покупця],
	B.[br_firstName] AS [Ім'я покупця],
	AC.[airc_name] AS [Авіакомпанія],
	C.[city_name] AS [Місто],
	AP.[airP_name] AS [Аеропорт],
	Pl.[pln_model] AS [Борт],
	F.[fl_type] AS [Тип рейсу],
	F.[fl_dateTimeStartGMT] AS [Час вильоту],
	F.[fl_dateTimeArrival] AS [Час прибуття],
	[Цена] = (CASE
		WHEN T.[tkt_class] = N'Економ' THEN F.[fl_priceEconom] 
		WHEN T.[tkt_class] = N'Бізнес' THEN F.[fl_priceBusiness] 
		WHEN T.[tkt_class] = N'Перший' THEN F.[fl_priceFirst]
	END),
	[Стоимость] = (
	
	CASE
		WHEN T.[tkt_class] = N'Економ' THEN F.[fl_priceEconom] 
		WHEN T.[tkt_class] = N'Бізнес' THEN F.[fl_priceBusiness] 
		WHEN T.[tkt_class] = N'Перший' THEN F.[fl_priceFirst]
	END
	) * (1 + Pay.[pay_addCost] )
FROM [dbo].[Passenger] P
	INNER JOIN
		[dbo].[DocType] D
	ON 
		P.[pass_dT_id_FK] = D.[dT_id] 
	INNER JOIN
		[dbo].[Ticket] T
	ON
		P.[pass_id] = T.[tkt_pass_id_FK] 
	INNER JOIN
		[dbo].[Buyer] B
	ON
		T.[tkt_br_id_FK] = B.[br_id] 
	INNER JOIN 
		[dbo].[Flight] F
	ON
		T.[tkt_fl_id_FK] = F.[fl_id]
	INNER JOIN
		[dbo].[AirPort] AP
	ON
		F.[fl_airP_id_FK] = AP.[airP_id] 
	INNER JOIN
		[dbo].[City] C
	ON
		AP.[airP_city_id_FK] = C.[city_id] 
	INNER JOIN
		[dbo].[Aircompany] AC
	ON
		F.[fl_airc_id_FK] = AC.[airc_id] 
	INNER JOIN
		[dbo].[Plane] Pl
	ON
		F.[fl_pln_id_FK] = Pl.[pln_id] 
	INNER JOIN
		[dbo].[Payment] Pay
	ON
		B.[br_pay_id_FK] = Pay.[pay_id] 
WHERE 		
	B.[br_lastName] LIKE N'%'+@LastName+N'%' OR B.[br_lastName] LIKE N'%'+@FirstName+N'%'
ORDER BY
	B.[br_id], F.[fl_id]