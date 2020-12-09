CREATE TABLE [dbo].[City]
(
	[city_id] INT NOT NULL IDENTITY , 
    [city_cntr_id_FK] INT NOT NULL, 
    [city_name] NVARCHAR(50) NOT NULL, 
    [city_population] BIGINT NOT NULL, 
    [city_GMT] DATETIME NOT NULL, 
    [city_signGMT] NVARCHAR(1) NOT NULL, 
    CONSTRAINT [City_PK] PRIMARY KEY ([city_id]), 
    CONSTRAINT [City_Country_FK] FOREIGN KEY ([city_cntr_id_FK]) REFERENCES [Country]([cntr_id])
)