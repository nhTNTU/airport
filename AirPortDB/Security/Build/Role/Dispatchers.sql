CREATE ROLE "Dispatchers"
GO
EXEC sp_addrolemember @rolename = 'Dispatchers', @membername = 'VovaVasilishin';
GO
EXEC sp_addrolemember @rolename = 'Dispatchers', @membername = 'RuslanVoityk';