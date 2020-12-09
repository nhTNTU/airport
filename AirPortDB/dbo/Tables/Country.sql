CREATE TABLE [dbo].[Country]
(
	[cntr_id] INT NOT NULL IDENTITY , 
    [cntr_name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [Country_PK] PRIMARY KEY ([cntr_id])
)