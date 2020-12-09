CREATE TABLE [dbo].[Buyer]
(
	[br_id] INT NOT NULL IDENTITY ,
	[br_pay_id_FK] INT NOT NULL,
	[br_lastName] NVARCHAR (50) NOT NULL,
	[br_firstName] NVARCHAR (50) NOT NULL,
	[br_phone] NVARCHAR (15) NOT NULL,
	[br_altPhone] NVARCHAR (15) NOT NULL,
	[br_timeToConnect] NVARCHAR (100) NOT NULL,
	[br_deliveryAdress] NVARCHAR (100) NOT NULL, 
    CONSTRAINT [Buyer_PK] PRIMARY KEY ([br_id]), 
    CONSTRAINT [Buyer_Payment_FK] FOREIGN KEY ([br_pay_id_FK]) REFERENCES [Payment]([pay_id])
)