CREATE TABLE [dbo].[Passenger]
(
	[pass_id] INT NOT NULL IDENTITY ,
	[pass_dT_id_FK] INT NOT NULL,
	[pass_lastName] NVARCHAR (50) NOT NULL,
	[pass_firstName] NVARCHAR (50) NOT NULL,
	[pass_birthDate] DATE NOT NULL,
	[pass_gender] NVARCHAR (10) NOT NULL,
	[pass_docNumber] NVARCHAR (20) NOT NULL, 
    CONSTRAINT [Passenger_PK] PRIMARY KEY ([pass_id]), 
    CONSTRAINT [Passenger_DocType_FK] FOREIGN KEY ([pass_dT_id_FK]) REFERENCES [DocType]([dT_id])
)
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