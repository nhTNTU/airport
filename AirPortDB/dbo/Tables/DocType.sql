CREATE TABLE [dbo].[DocType]
(
	[dT_id] INT NOT NULL IDENTITY ,
	[dT_name] NVARCHAR (50) NOT NULL,
	[dT_description] NVARCHAR (50) NOT NULL,
	[dT_regularExpression] NVARCHAR (100) NOT NULL, 
    CONSTRAINT [DocType_PK] PRIMARY KEY ([dT_id])
)