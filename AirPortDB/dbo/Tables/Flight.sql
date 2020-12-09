CREATE TABLE [dbo].[Flight]
(
	[fl_id] INT NOT NULL IDENTITY , 
    [fl_airc_id_FK] INT NOT NULL, 
    [fl_pln_id_FK] INT NOT NULL, 
    [fl_airP_id_FK] INT NOT NULL,
	[fl_type] NVARCHAR (32) NOT NULL,
	[fl_dateTimeStart] DATETIME NOT NULL,
	[fl_duration] DATETIME NOT NULL,
	[fl_dateTimeArrival] DATETIME NULL,
	[fl_numOfFlights] INT NOT NULL,
	[fl_periodicity] DATETIME NOT NULL,
	[fl_priceEconom] MONEY NOT NULL,
	[fl_priceBusiness] MONEY NOT NULL,
	[fl_priceFirst] MONEY NOT NULL,
	[fl_dateTimeStartGMT] DATETIME NULL,
	[fl_dateTimeArrivalGMT] DATETIME NULL,
	[fl_status] NVARCHAR (32) NULL, 
    CONSTRAINT [Flight_Aircompany_FK] FOREIGN KEY ([fl_airc_id_FK]) REFERENCES [Aircompany]([airc_id]),
	CONSTRAINT [Flight_Plane_FK] FOREIGN KEY ([fl_pln_id_FK]) REFERENCES [Plane]([pln_id]),
	CONSTRAINT [Flight_AirPort_FK] FOREIGN KEY ([fl_airP_id_FK]) REFERENCES [AirPort]([airP_id]), 
    CONSTRAINT [Flight_PK] PRIMARY KEY ([fl_id])
)
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
	SET [fl_status] = N'За роскладом'
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