CREATE ROLE "TicketBuyer"
GO
EXEC sp_addrolemember @rolename = 'TicketBuyer', @membername = 'ViktorRikaluk';