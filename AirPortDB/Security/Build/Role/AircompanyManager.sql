CREATE ROLE "AircompanyManager"
GO
EXEC sp_addrolemember @rolename = 'AircompanyManager', @membername = 'KrisDemyda';