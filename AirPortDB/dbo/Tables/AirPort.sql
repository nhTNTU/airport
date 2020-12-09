CREATE TABLE [dbo].[AirPort]
(
	[airP_id] INT NOT NULL IDENTITY , 
    [airP_city_id_FK] INT NOT NULL, 
    [airP_name] NCHAR(10) NOT NULL, 
    CONSTRAINT [AirPort_PK] PRIMARY KEY ([airP_id]), 
    CONSTRAINT [AirPort_City_FK] FOREIGN KEY ([airP_city_id_FK]) REFERENCES [City]([city_id])
)