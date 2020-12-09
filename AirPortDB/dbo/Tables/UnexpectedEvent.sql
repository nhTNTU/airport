CREATE TABLE [dbo].[UnexpectedEvent]
(
	[uE_id] INT NOT NULL IDENTITY,
	[uE_fl_id_FK] INT NOT NULL,
	[uE_eventType] NVARCHAR (50) NOT NULL,
	[uE_dateTimeEvent] DATETIME NOT NULL,
	[uE_Duration] DATETIME NOT NULL,
	[ue_reason] NVARCHAR (MAX) NOT NULL, 
    CONSTRAINT [UnexpectedEvent_PK] PRIMARY KEY ([uE_id]), 
    CONSTRAINT [UnexpectedEvent_Flight_FK] FOREIGN KEY ([uE_fl_id_FK]) REFERENCES [Flight]([fl_id])
)
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