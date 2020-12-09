
USE AirportDB
GO

-- Insert
USE airportDB;
GO

-- Aircompany
INSERT INTO [dbo].[Aircompany] ([airc_name], [airc_phone], [airc_adress])
	VALUES
	(N'S7 WINDROSE', '+38 (096) 1827523', N'м. Київ'),
	(N'Wizz Air', '+38 (093) 5588938', N'м. Вечеш'),
	(N'Джек Воробей', '+38 (097) 1234567', N'г. Москва');
GO

-- Airport
INSERT INTO [dbo].[Airport] ([airP_city_id_FK], [airP_name]) VALUES
(1, N'Бориспіль'),
(1, N'Жульяни'),
(5, N'МакКарран'),
(2, N'Внуково'),
(3, N'Астаново'),
(5, N'Шанхай-1'),
(5, N'Шанхай-2'),
(5, N'Международный аэропорт Китая'),
(4, N'Аэропорт Токио'),
(6, N'Международный Аэропорт Лос-Анжелеса'),
(7, N'Емельяново');
GO

-- Buyer
INSERT INTO [dbo].[Buyer] ([br_pay_id_FK], [br_lastName], [br_firstName], [br_phone], [br_altPhone], [br_timeToConnect], [br_deliveryAdress])
VALUES
(1, N'Ежевикова', N'Виктория', N'+79230192857', NULL, N'Вечером, после 19', N'ул. Челюскинцев, 35, кв. 124'),
(1, N'Петросян', N'Евгений', N'+79135748383', NULL, N'После концерта', N'ул. Кривого зеркала');
GO

-- City
INSERT INTO [dbo].[City] ([city_id], [city_cntr_id_FK], [city_name], [city_population], [city_GMT], [city_signGMT]) VALUES
(1, 1, N'Новосибирск', 1500000, '07:00:00', '+'),
(2, 1, N'Москва', 8500000, '04:00:00', '+'),
(3, 2, N'Астана', 2000000, '06:00:00', '+'),
(4, 3, N'Токио', 10000000, '09:00:00', '+'),
(5, 4, N'Шанхай', 7000000, '08:00:00', '+'),
(6, 5, N'Лос-Анжелес', 8000000, '07:00:00', '-'),
(7, 1, N'Красноярск', 1000000, '08:00:00', '+'),
(8, 1, N'Урюпинск', 400000, '05:00:00', '+');
GO

-- Country
INSERT INTO [dbo].[Country] ([cntr_name]) VALUES
(N'Україна'),
(N'Китай'),
(N'Япония'),
(N'Німечина'),
(N'США');
GO

-- DocType
INSERT INTO [dbo].[DocType] ([dT_name], [dT_description], [dT_regularExpression])
VALUES
(N'Паспорт гражданина РФ', N'10 цифр: серия и номер слитно', N'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]');
GO

INSERT INTO [dbo].[DocType] ([dT_name], [dT_description], [dT_regularExpression])
VALUES
(N'Заграничный паспорт', N'11 цифр', N'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]');
GO

-- Event
INSERT INTO [dbo].[Event] ([e_fl_id_FK], [e_eventType], [e_dateTimeEvent])
VALUES
(10, N'Вилетів', '2012-08-06 07:10:00');
GO

INSERT INTO [dbo].[Event] ([e_fl_id_FK], [e_eventType], [e_dateTimeEvent])
VALUES
(10, N'Прибув', '2012-08-06 11:10:00');
GO

INSERT INTO [dbo].[Event] ([e_fl_id_FK], [e_eventType], [e_dateTimeEvent])
VALUES
(1, N'Вилетів', '2012-08-06 19:40:00');
GO

INSERT INTO [dbo].[Event] ([e_fl_id_FK], [e_eventType], [e_dateTimeEvent])
VALUES
(2, N'Вилетів', '2012-09-06 20:00:00');
GO

INSERT INTO [dbo].[Event] ([e_fl_id_FK], [e_eventType], [e_dateTimeEvent])
VALUES
(2, N'Прибув', '2012-09-06 23:00:00');
GO

INSERT INTO [dbo].[Event] ([e_fl_id_FK], [e_eventType], [e_dateTimeEvent])
VALUES
(5, N'Вилетів', '2012-09-06 20:00:00');
GO

-- Flight
INSERT INTO [dbo].[Flight] 
([idAircompany], [fl_pln_id_FK], [fl_airP_id_FK], [fl_type], [fl_dateTimeStart], [fl_duration], [fl_numOfFlights], [fl_periodicity], [fl_priceEconom], [fl_priceBusiness], [fl_priceFirst])
VALUES
(1, 1, 2, N'Вихідний', '2012-14-06 07:00:00', '04:00:00', 5, '1900-02-01 00:00:00', 12400, 15000, 20000);
GO

INSERT INTO [dbo].[Flight] 
([idAircompany], [fl_pln_id_FK], [fl_airP_id_FK], [fl_type], [fl_dateTimeStart], [fl_duration], [fl_numOfFlights], [fl_periodicity], [fl_priceEconom], [fl_priceBusiness], [fl_priceFirst])
VALUES
(1, 1, 3, N'Вхідний', '2012-20-06 22:00:00', '04:00:00', 4, '1900-07-01 00:00:00', 12400, 15000, 20000);
GO

INSERT INTO [dbo].[Flight] 
([idAircompany], [fl_pln_id_FK], [fl_airP_id_FK], [fl_type], [fl_dateTimeStart], [fl_duration], [fl_numOfFlights], [fl_periodicity], [fl_priceEconom], [fl_priceBusiness], [fl_priceFirst])
VALUES
(2, 3, 10, N'Вихідний', '2012-08-06 19:00:00', '06:00:00', 2, '1900-02-01 00:00:00', 20000, 21000, 22000);
GO

INSERT INTO [dbo].[Flight] 
([idAircompany], [fl_pln_id_FK], [fl_airP_id_FK], [fl_type], [fl_dateTimeStart], [fl_duration], [fl_numOfFlights], [fl_periodicity], [fl_priceEconom], [fl_priceBusiness], [fl_priceFirst])
VALUES
(2, 3, 5, N'Вхідний', '2012-08-06 05:00:00', '06:00:00', 1, '1900-01-01 00:00:00', 20000, 21000, 22000);
GO

INSERT INTO [dbo].[Flight] 
([idAircompany], [fl_pln_id_FK], [fl_airP_id_FK], [fl_type], [fl_dateTimeStart], [fl_duration], [fl_numOfFlights], [fl_periodicity], [fl_priceEconom], [fl_priceBusiness], [fl_priceFirst])
VALUES
(2, 3, 7, N'Вхідний', '2012-08-06 05:00:00', '06:00:00', 2, '1900-07-01 00:00:00', 20000, 21000, 22000);
GO

-- Passengers
INSERT INTO [dbo].[Passenger] ([pass_dT_id_FK], [pass_lastName], [pass_firstName], [pass_birthDate], [pass_gender], [pass_docNumber])
VALUES
(1, N'Полтарацкий', N'Константин', '1990-11-05', N'Мужской', N'5004630007');
GO

INSERT INTO [dbo].[Passenger] ([pass_dT_id_FK], [pass_lastName], [pass_firstName], [pass_birthDate], [pass_gender], [pass_docNumber])
VALUES
(1, N'Ежевикова', N'Виктория', '1990-10-15', N'Женский', N'5008392837');
GO

INSERT INTO [dbo].[Passenger] ([pass_dT_id_FK], [pass_lastName], [pass_firstName], [pass_birthDate], [pass_gender], [pass_docNumber])
VALUES
(2, N'Болгов', N'Станислав', '1985-12-23', N'Мужской', N'50204639307');
GO

INSERT INTO [dbo].[Passenger] ([pass_dT_id_FK], [pass_lastName], [pass_firstName], [pass_birthDate], [pass_gender], [pass_docNumber])
VALUES
(1, N'Медведев', N'Дмитрий', '1945-05-09', N'Мужской', N'5004630283');
GO

INSERT INTO [dbo].[Passenger] ([pass_dT_id_FK], [pass_lastName], [pass_firstName], [pass_birthDate], [pass_gender], [pass_docNumber])
VALUES
(1, N'Головач', N'Елена', '1991-10-07', N'Женский', N'5004672007');
GO

-- Payment
INSERT INTO [dbo].[Payment] ([pay_name], [pay_addCost])
VALUES
(N'Каси авіакомпаній', 0),
(N'Платіжна система PayPal', 0.05),
(concat(N'Оплата кур', char(39), N'єру'), 0.1);
GO

-- Plane
INSERT INTO [dbo].[Plane] ([id], [pln_airc_id_FK], [pln_model], [pln_number]) VALUES
(1, 1, N'ИЛ-86', N'S7-IL86-293'),
(2, 1, N'BOEING-747', N'S7-BOE747-492'),
(3, 2, N'FELIX-F', N'AF-FELF-201'),
(4, 2, N'VOLODYA', N'AF-VOL-184'),
(5, 3, N'ТУ-160', N'JV-TU160-124'),
(6, 3, N'MATIS-G6', N'JV-MATG6-134');
GO

-- Tickets
INSERT INTO [dbo].[Ticket] 
([tkt_fl_id_FK], [tkt_pass_id_FK], [tkt_br_id_FK], [tkt_class])
VALUES
(1, 1, 1, N'Бізнес'),
(1, 2, 1, N'Бізнес'),
(1, 3, 1, N'Бізнес'),
(6, 1, 1, N'Перший'),
(6, 2, 1, N'Перший'),
(6, 3, 1, N'Перший'),
(10, 4, 2, N'Економ'),
(10, 5, 2, N'Економ');
GO

-- UnexpactedEvents
INSERT INTO [dbo].[UnexpectedEvent] ([uE_fl_id_FK], [uE_eventType], [uE_dateTimeEvent], [uE_Duration], [ue_reason])
VALUES
(3, N'Затримується', '2012-07-08 12:35', '1900-02-01 00:00:00', N'Нельотна погода');
GO

INSERT INTO [dbo].[UnexpectedEvent] ([uE_fl_id_FK], [uE_eventType], [uE_dateTimeEvent], [uE_Duration], [ue_reason])
VALUES
(4, N'Скасовано', '2012-27-05 16:15', NULL, N'Проблеми з законодавством');
GO

--Вывод данных

--Вывод информации о городе и стране



EXEC [allcity];
GO

--Вывод информации о ближайших рейсах за определённый период времени

--Переменная @FutureDate - это дата, ограничивающая промежуток времени, должна быть позже настоящего времени


/*
 */

EXEC [FutureFlights] @FutureDate = '2012-20-08';
GO

--Вывод данных о рейсе по городу. Переменная @City - это название города
EXEC [FlightsByCity] @City = N'Лос-Анжелес';
GO

--Вывод информации о событиях, связанных с самолетом на рейсе
EXEC [FlightsWithEvents];
GO

--Выбор непредвиденных событий
EXEC [UEvents];
GO

--Формирование отчета о движении самолетов
EXEC [PastFlights] @PastDate = '2012-12-04';
GO

--Вывод информации об авиакомпаниях и принадлежащих им самолётах
EXEC [AircompWithPlanes];
GO

--Вывод информации о рейсах по стране
EXEC [FlightsByCountry] @Country = 'США';
GO

--Вывод информации о покупателях
EXEC [Buyers];
GO

--Вывод информации о билетах, которые купил определённый человек
EXEC [Passeng] @LastName = N'Ежевик', @FirstName = N'Ви';
GO














/*
--sys.database_permissions, sp_helpuser
SELECT * FROM "sys"."database_permissions" where "major_id" = 2021582240
select OBJECT_NAME(2021582240)
select USER_NAME(2)
select USER
select CURRENT_USER
exec sp_helpuser 
SELECT OBJECT_ID('InsertFlight', 'P'); 
select OBJECT_ID('selectflights', 'P');
declare @a decimal;
set @a = scope_identity();
print @a;
exec sp_helprotect @username = 'KPoltarackiy'
select * from sys.procedures WHERE name NOT LIKE 'sp_%'
*/
/*
WHERE (@id = [id] OR @id = 0) AND ...

*/

GO


--Курсор, отображающий 5 ближайших вылетов
DECLARE "Top5Flights" CURSOR
FOR
SELECT TOP(5) "FROM" =((SELECT "name" FROM "dbo"."Country" WHERE "id" = 1) + ', ' + (SELECT "Name" FROM "dbo"."City" WHERE "id" = 1))
	, CO."name" + ', ' + CI."Name" AS "TO"
	, AC."AircompanyName" AS "Aircompany"
	, CONVERT(NVARCHAR, F."DateTimeStart", 120) AS "DateTimeStart"
	, CONVERT(NVARCHAR, F."DateTimeArrival", 120) AS "DateTimeArrival"
	, CONVERT(NVARCHAR, F."DateTimeArrivalGMT", 120) AS "DateTimeArrivalGMT"
	, F."Status"
	, F."id"
FROM "dbo"."Flight" F
INNER JOIN "dbo"."Aircompany" AC
	ON F."idAircompany" = AC."id" 
INNER JOIN "dbo"."Plane" P
	ON F."idPlane" = P."id" 
INNER JOIN "dbo"."AirPort" AP
	ON F."idAirPort" = AP."id" 
INNER JOIN "dbo"."City" CI
	ON AP."idCity" = CI."id" 
INNER JOIN "dbo"."Country" CO
	ON CI."idCountry" = CO."id" 
WHERE F."DateTimeStart" > GETDATE() AND F."FlightType" = N'Исходящий'
ORDER BY F."DateTimeStart";

OPEN "Top5Flights";

DECLARE @FROM NVARCHAR(100);
DECLARE @TO NVARCHAR(100);
DECLARE @Aircompany NVARCHAR(50);
DECLARE @DateTimeStart NVARCHAR(30);
DECLARE @DateTimeArrival NVARCHAR(30);
DECLARE @DateTimeArrivalGMT NVARCHAR(30);
DECLARE @Status NVARCHAR(20);
DECLARE @id INT;

FETCH NEXT FROM "Top5Flights" INTO @FROM
	, @TO
	, @Aircompany
	, @DateTimeStart
	, @DateTimeArrival
	, @DateTimeArrivalGMT
	, @Status
	, @id;

WHILE @@FETCH_STATUS <> -1
BEGIN

PRINT N'Рейс номер ' + CONVERT(NVARCHAR, @id);
PRINT N'				  		  Куда:	' + @TO;
PRINT N'				 		    Из:	' + @FROM;
PRINT N'				 	  Вылетает:	' + @DateTimeStart;
PRINT N' Прибывает по текущему времени:	' + @DateTimeArrival;
PRINT N' Прибывает по местному времени:	' + @DateTimeArrivalGMT;
PRINT N'				  Статус рейса: ' + @Status;
PRINT N'				  Авиакомпания: ' + @Aircompany;
PRINT '';
PRINT '';

FETCH NEXT FROM "Top5Flights" INTO @FROM
	, @TO
	, @Aircompany
	, @DateTimeStart
	, @DateTimeArrival
	, @DateTimeArrivalGMT
	, @Status
	, @id;

END

PRINT 'Приятного путешествия!';

CLOSE "Top5Flights";
DEALLOCATE "Top5Flights";


GO



--Триггер на автоматичне заповнення часу прибуття і місцевого часу.
CREATE TRIGGER [AutoDateTimeArrival]
ON [dbo].[Flight]
AFTER INSERT, UPDATE
AS
	UPDATE [dbo].[Flight]
	SET [fl_dateTimeArrival] = [Flight].[fl_dateTimeStart] + [Flight].[fl_duration]
	FROM inserted
	DECLARE @GMT DATETIME = (
		SELECT DISTINCT [city_GMT]
		FROM [dbo].[City] c
			INNER JOIN 
				[AirPort] a
		ON 
			c.[city_id] = a.[airP_city_id_FK] AND a.[airP_id] = (SELECT DISTINCT [fl_airP_id_FK] FROM inserted)
	)
	
	DECLARE @GMTSign NVARCHAR(1) = (
		SELECT DISTINCT [city_signGMT] 
		FROM [dbo].[City] c
			INNER JOIN 
				[AirPort] a
		ON 
			c.[city_id] = a.[airP_city_id_FK] AND a.[airP_id] = (SELECT DISTINCT [airP_id] FROM inserted)
	)
	
	DECLARE @MyGMT DATETIME = (
		SELECT [city_GMT] FROM [dbo].[City] WHERE [city_id] = 1
	)
	
	DECLARE @FlightType NVARCHAR (20) = (
	SELECT DISTINCT [fl_type] FROM inserted
	)
	
	IF (@GMTSign = '+' AND @FlightType = 'Вхідний')
	BEGIN
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeStartGMT] = [Flight].[fl_dateTimeStart] + @GMT - @MyGMT
		FROM inserted
		
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeArrivalGMT] = [Flight].[fl_dateTimeArrival]
		FROM inserted
	END
	
	IF (@GMTSign = '-' AND @FlightType = 'Вхідний')
	BEGIN
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeStartGMT] = [Flight].[fl_dateTimeStart] - @GMT - @MyGMT
		FROM inserted
		
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeArrivalGMT] = [Flight].[fl_dateTimeArrival] + @GMT - @MyGMT
		FROM inserted
	END
	
	IF (@GMTSign = '+' AND @FlightType = 'Вихідний')
	BEGIN
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeArrivalGMT] = [Flight].[fl_dateTimeArrival] + @GMT - @MyGMT
		FROM inserted
		
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeStartGMT] = [Flight].[fl_dateTimeStart]
		FROM inserted
	END
	
	IF (@GMTSign = '-' AND @FlightType = 'Вихідний')
	BEGIN
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeArrivalGMT] = [Flight].[fl_dateTimeArrival] - @GMT - @MyGMT
		FROM inserted
		
		UPDATE [dbo].[Flight]
		SET [fl_dateTimeStartGMT] = [Flight].[fl_dateTimeStart]
		FROM inserted
	END
GO


--Додавання періодичних рейсів

--Додавання записів про періодичний рейс за допомогою циклу while
CREATE TRIGGER [AutoAddPeriodicalFlights]
ON [dbo].[Flight]
AFTER INSERT
AS
	DECLARE @Count INT = 0;
	DECLARE @GlobalCount INT = (SELECT [fl_numOfFlights] FROM inserted);
	SET @Count = (SELECT [fl_numOfFlights] FROM inserted);
	DECLARE @DateTimeStartGlobal DATETIME = (SELECT [fl_dateTimeStart] FROM inserted);
	
	UPDATE [dbo].[Flight]
	SET [fl_status] = N'По расписанию'
	WHERE [fl_id] = (SELECT [fl_id] FROM inserted)
	
	DECLARE @id INT;
		DECLARE @idAirCompany INT;
		DECLARE @idPlane INT;
		DECLARE @idAirPort INT;
		DECLARE @FlightType NVARCHAR (20);
		DECLARE @DateTimeStart DATETIME;
		DECLARE @Duration DATETIME;
		DECLARE @Periodicity DATETIME;
		DECLARE @PriceEconom INT;
		DECLARE @PriceBusiness INT;
		DECLARE @PriceFirst INT;

		SET @idAirCompany = (SELECT [fl_airc_id_FK] FROM inserted);
		SET @idAirPort = (SELECT [fl_airP_id_FK] FROM inserted);
		SET @idPlane = (SELECT [fl_pln_id_FK] FROM inserted);
		SET @FlightType = (SELECT [fl_type] FROM inserted);
		SET @Periodicity = (SELECT [fl_periodicity] FROM inserted);
		SET @DateTimeStart = (SELECT [fl_dateTimeStart] FROM inserted)
		
		SET @Duration = (SELECT [fl_duration] FROM inserted);
		SET @PriceEconom = (SELECT [fl_priceEconom] FROM inserted);
		SET @PriceBusiness = (SELECT [fl_priceBusiness] FROM inserted);
		SET @PriceFirst = (SELECT [fl_priceFirst] FROM inserted);
	
	WHILE (@Count > 1)
	BEGIN
		SET @id = (SELECT TOP (1) [fl_id]  FROM [dbo].[Flight] ORDER BY [fl_id] DESC) + 1;
		SET @DateTimeStart = @DateTimeStart + @Periodicity;
		SET @Count = @Count - 1;
		
		INSERT INTO [dbo].[Flight] 
		([fl_airc_id_FK],[fl_pln_id_FK], [fl_airP_id_FK], [fl_type], [fl_dateTimeStart], [fl_duration],
			[fl_numOfFlights], [fl_periodicity], [fl_priceEconom], [fl_priceBusiness], [fl_priceFirst], [fl_status])
		VALUES
		(@idAirCompany, @idPlane, @idAirPort, @FlightType, @DateTimeStart, @Duration, @Count, @Periodicity, @PriceEconom, @PriceBusiness, @PriceFirst, N'За роскладом')
	END
GO


--Триггер, який перевіряє, що для кожного рейсу не більше однієї події "вилетів"
CREATE TRIGGER [NoMoreThanOneStartEvent]
ON [dbo].[Event] 
AFTER INSERT, UPDATE
AS
	DECLARE @idFlight INT = (SELECT [e_fl_id_FK] FROM inserted);
	DECLARE @EventCount INT;
	SET @EventCount = (SELECT COUNT (*)
	FROM [dbo].[Event]
	WHERE [e_fl_id_FK] = @idFlight AND [e_eventType] = N'Вилетів');
	IF (@EventCount > 1)
	BEGIN
		RAISERROR (N'Літак не може вилетіти 2 рази підряд. Така подія вже існує.', 5, 1);
		ROLLBACK TRAN;
	END
GO


--Триггер, який перевіряє, що для кожного рейсу не більше однієї події "прибув"
CREATE TRIGGER [NoMoreThanOneArrivalEvent]
ON [dbo].[Event] 
AFTER INSERT, UPDATE
AS
	DECLARE @idFlight INT = (SELECT [e_fl_id_FK] FROM inserted);
	DECLARE @EventCount INT;
	SET @EventCount = (SELECT COUNT (*)
	FROM [dbo].[Event]
	WHERE [e_fl_id_FK] = @idFlight AND [e_eventType] = N'Прибув');
	IF (@EventCount > 1)
	BEGIN
		RAISERROR (N'Літак не може прибути 2 рази підряд. Така подія вже існує.', 5, 2);
		ROLLBACK TRAN;
	END
GO


--Триггер, який перевіряє, при вставці "прибув" чи вже існує запис про отравлення
CREATE TRIGGER [NoArriveWithoutStart]
ON [dbo].[Event] 
AFTER INSERT, UPDATE
AS
	DECLARE @idFlight INT = (SELECT [e_fl_id_FK] FROM inserted);
	DECLARE @EventCount INT;
	DECLARE @EventType NVARCHAR(50) = (SELECT [e_eventType] FROM inserted);
	SET @EventCount = (SELECT COUNT (*)
	FROM [dbo].[Event]
	WHERE [e_fl_id_FK] = @idFlight AND [e_eventType] = N'Вилетів');
	IF (@EventCount = 0 AND @EventType = N'Прибув')
	BEGIN
		RAISERROR (N'Літак не може прибути, так як він не вилетів. Створіть подію виліту.', 5, 2);
		ROLLBACK TRAN;
	END
GO


--Триггер, перевіряючий, що подія "вилетів" раніше, ніж "прибув"
--DROP TRIGGER [StartIsEarlierThanArrive]
CREATE TRIGGER [StartIsEarlierThanArrive]
ON [dbo].[Event]
AFTER INSERT, UPDATE
AS
	DECLARE @DateTimeStart DATETIME;
	DECLARE @DateTimeArrive DATETIME;
	DECLARE @FlightID INT = (SELECT [e_fl_id_FK] FROM inserted)
	DECLARE @Count INT = (SELECT COUNT (*) FROM [dbo].[Event] WHERE [e_fl_id_FK] = @FlightID AND [e_eventType] = N'Вилетів');
	IF (@Count = 1)
	BEGIN
		SET @DateTimeStart = (SELECT [e_dateTimeEvent] FROM [dbo].[Event] WHERE [e_fl_id_FK] = @FlightID AND [e_eventType] = N'Вилетів')
		SET @DateTimeArrive = (SELECT [e_dateTimeEvent] FROM inserted);
		IF (@DateTimeStart > @DateTimeArrive)
		BEGIN
			RAISERROR (N'Літак не може прибути раніше, ніж вилетів. Перевірте коректність заповнених даних чи відредагуйте подію виліту', 5, 2);
			ROLLBACK TRAN;
		END
	END
GO


--Триггер на автоматичне формування статуса рейсу "вилетів"
CREATE TRIGGER [StatusStart]
ON [dbo].[Event]
FOR INSERT, UPDATE
AS
	DECLARE @idFlight INT;
	SET @idFlight = (SELECT [e_fl_id_FK] FROM inserted);
	DECLARE @EventType NVARCHAR (50) = (SELECT [e_eventType] FROM inserted);
	DECLARE @Arrived INT = (SELECT COUNT (*) FROM [dbo].[Event] WHERE [e_fl_id_FK] = @idFlight AND [e_eventType] = N'Прибув')
	IF (@EventType = N'Вилетів' AND @Arrived = 0)
	BEGIN
		UPDATE [dbo].[Flight]
		SET [fl_status] = N'Вилетів'
		WHERE [fl_id] = @idFlight
	END
GO


--Триггер на формування статусу "прибув"
CREATE TRIGGER [AutoArrived]
ON [dbo].[Event]
FOR INSERT, UPDATE
AS
	DECLARE @EventType NVARCHAR (50) = (SELECT [e_eventType] FROM inserted);
	DECLARE @idFlight INT = (SELECT [e_fl_id_FK] FROM inserted);
	IF (@EventType = N'Прибув')
	BEGIN
		UPDATE [dbo].[Flight]
		SET [fl_status] = N'Прибув'
		WHERE [fl_id] = @idFlight
	END
GO


--Триггер, що забороняє створювати події, якщо рейс скасовано
CREATE TRIGGER [NoEventsIfCancelled]
ON [dbo].[Event]
AFTER INSERT, UPDATE
AS
	DECLARE @CountCancelEvents INT;
	DECLARE @idFlight INT = (SELECT [e_fl_id_FK] FROM inserted);
	SET @CountCancelEvents = (
	SELECT COUNT (*) 
	FROM [dbo].[UnexpectedEvent] 
	WHERE [uE_fl_id_FK] = @idFlight AND [uE_eventType] = N'Скасовано');
	IF (@CountCancelEvents >= 1)
	BEGIN
		RAISERROR (N'Рейс скасовано, створити подію неможливоо.', 5, 1)
		ROLLBACK TRAN;
	END
GO


--Триггер, що забороняє створювати подію "Затримується" або "Скасовано", якщо літак вже вилетів
CREATE TRIGGER [NoDelayOrCancellIfStarted]
ON [dbo].[UnexpectedEvent]
AFTER INSERT, UPDATE
AS
	DECLARE @CountStartEvents INT;
	DECLARE @idFlight INT = (SELECT [uE_fl_id_FK] FROM inserted);
	SET @CountStartEvents = (
	SELECT COUNT (*) 
	FROM [dbo].[Event] 
	WHERE [e_fl_id_FK] = @idFlight AND [e_eventType] = N'Вилетів');
	IF (@CountStartEvents = 1)
	BEGIN
		RAISERROR (N'Літак вже вилетів, рейс не може бути затриманий або скасований.', 5, 1)
		ROLLBACK TRAN;
	END
GO


--Триггер, що формує статус "Затримується" або "Скасовано"
CREATE TRIGGER [DelayedOrCalcelled]
ON [dbo].[UnexpectedEvent]
AFTER INSERT, UPDATE
AS
	DECLARE @idFlight INT = (
	SELECT [uE_fl_id_FK] 
	FROM 
	inserted);
	UPDATE [Flight]
	SET [fl_status] = (SELECT [uE_eventType] FROM inserted)
	WHERE [fl_id] = @idFlight;
GO


--Триггер, що перевіряє, що заповнене поле "номер документа", що посвідчує особу пасажира, відповідає регулярному виразу
CREATE TRIGGER [DocNumberMatchesToRE]
ON [dbo].[Passenger]
AFTER INSERT, UPDATE
AS
	DECLARE @Doc INT = (SELECT [pass_dT_id_FK] FROM inserted);
	DECLARE @RE NVARCHAR (100) = (SELECT [dT_regularExpression] FROM [dbo].[DocType] WHERE [dT_id] = @Doc);
	DECLARE @DocNum NVARCHAR (20) = (SELECT [pass_docNumber] FROM inserted);
	IF (@DocNum NOT LIKE @RE)
	BEGIN
		RAISERROR (N'Невірно введено номер документа.', 5, 6);
		ROLLBACK TRAN;
	END
GO
