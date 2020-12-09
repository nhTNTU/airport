CREATE TABLE [dbo].[Plane]
(
	[pln_id] INT NOT NULL IDENTITY , 
    [pln_airc_id_FK] INT NOT NULL, 
    [pln_model] NVARCHAR(20) NOT NULL, 
    [pln_number] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [Plane_PK] PRIMARY KEY ([pln_id]), 
    CONSTRAINT [Plane_Aircompany_FK] FOREIGN KEY ([pln_airc_id_FK]) REFERENCES [Aircompany]([airc_id])
)