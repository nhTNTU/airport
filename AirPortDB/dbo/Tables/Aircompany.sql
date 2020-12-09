CREATE TABLE [dbo].[Aircompany]
(
	[airc_id] INT NOT NULL IDENTITY, 
    [airc_name] NVARCHAR(100) NOT NULL, 
    [airc_phone] NVARCHAR(20) NOT NULL, 
    [airc_adress] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [Aircompany_PK] PRIMARY KEY ([airc_id])
)