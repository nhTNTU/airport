CREATE TABLE [dbo].[Event]
(
	[e_id] INT NOT NULL IDENTITY, 
	[e_fl_id_FK] INT NOT NULL,
	[e_eventType] NVARCHAR (50) NOT NULL,
	[e_dateTimeEvent] DATETIME NOT NULL,
    CONSTRAINT [Event_PK] PRIMARY KEY ([e_id]), 
    CONSTRAINT [Event_Flight_FK] FOREIGN KEY ([e_fl_id_FK]) REFERENCES [Flight]([fl_id])
)
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