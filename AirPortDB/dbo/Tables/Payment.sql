CREATE TABLE [dbo].[Payment]
(
	[pay_id] INT NOT NULL IDENTITY ,
	[pay_name] NVARCHAR (50),
	[pay_addCost] DECIMAL (4, 2), 
    CONSTRAINT [Payment_PK] PRIMARY KEY ([pay_id]),
)