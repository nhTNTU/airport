CREATE ROLE "TopManagers"
GO
EXEC sp_addrolemember @rolename = 'TopManagers', @membername = 'NazarHolub';