CREATE TABLE [dbo].[Ticket]
(
	[tkt_id] INT NOT NULL IDENTITY,
	[tkt_fl_id_FK] INT NOT NULL,
	[tkt_pass_id_FK] INT NOT NULL,
	[tkt_br_id_FK] INT NOT NULL,
	[tkt_class] NVARCHAR (20) NOT NULL, 
    CONSTRAINT [Ticket_PK] PRIMARY KEY ([tkt_id]), 
    CONSTRAINT [Ticket_Flight_FK] FOREIGN KEY ([tkt_fl_id_FK]) REFERENCES [Flight]([fl_id]),
	CONSTRAINT [Ticket_Passenger_FK] FOREIGN KEY ([tkt_pass_id_FK]) REFERENCES [Passenger]([pass_id]),
	CONSTRAINT [Ticket_Buyer_FK] FOREIGN KEY ([tkt_br_id_FK]) REFERENCES [Buyer]([br_id])
)