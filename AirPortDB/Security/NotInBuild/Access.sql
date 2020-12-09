--Створення логіна
--USE AirPortDB
--GO

GRANT EXECUTE ON "SelectFlights" TO "public";
GO

GRANT EXECUTE ON "RefCountriesSelect" TO "public";
GO

GRANT EXECUTE ON "SelectRefAirportListByCity" TO "public";
GO

GRANT EXECUTE ON "RefSelectCitiesListByID" TO "public";
GO

GRANT EXECUTE ON "SelectRefAircompaniesList" TO "public";
GO

GRANT EXECUTE ON "SelectRefPlaneList" TO "public";
GO

GRANT EXECUTE ON "GetAirport" TO "public";
GO

GRANT EXECUTE ON "GetCity" TO "public";
GO

--Керівники
GRANT EXECUTE ON "AirCompanySelect" TO "TopManagers";
GO

GRANT EXECUTE ON "AirсompanyInsert" TO "TopManagers";
GO

GRANT EXECUTE ON "AircompanyUpdate" TO "TopManagers";
GO

GRANT EXECUTE ON "AircompanyDelete" TO "TopManagers";
GO

GRANT EXECUTE ON "CountriesSelect" TO "TopManagers";
GO

GRANT EXECUTE ON "CountryInsert" TO "TopManagers";
GO

GRANT EXECUTE ON "CountryUpdate" TO "TopManagers";
GO

GRANT EXECUTE ON "CountryDelete" TO "TopManagers";
GO

GRANT EXECUTE ON "GetCountry" TO "TopManagers";
GO

GRANT EXECUTE ON "SelectCitiesList" TO "TopManagers";
GO

GRANT EXECUTE ON "CityInsert" TO "TopManagers";
GO

GRANT EXECUTE ON "CityUpdate" TO "TopManagers";
GO

GRANT EXECUTE ON "CityDelete" TO "TopManagers";
GO

GRANT EXECUTE ON "GetCity" TO "TopManagers";
GO

GRANT EXECUTE ON "SelectAirPortList" TO "TopManagers";
GO

GRANT EXECUTE ON "GetAirport" TO "TopManagers";
GO

GRANT EXECUTE ON "DeleteAirport" TO "TopManagers";
GO

GRANT EXECUTE ON "UpdateAirport" TO "TopManagers";
GO

GRANT EXECUTE ON "InsertAirport" TO "TopManagers";
GO

GRANT EXECUTE ON "SelectFlights" TO "TopManagers"
GO

--Диспетчери
GRANT EXECUTE ON "SelectFlights" TO "Dispatchers";
GO

GRANT EXECUTE ON "GetFlight" TO "Dispatchers";
GO

GRANT EXECUTE ON "InsertFlight" TO "Dispatchers";
GO

GRANT EXECUTE ON "UpdateFlight" TO "Dispatchers";
GO

GRANT EXECUTE ON "DeleteFlight" TO "Dispatchers";
GO

GRANT EXECUTE ON "SelectAirplaneList" TO "Dispatchers";
GO

GRANT EXECUTE ON "GetPlane" TO "Dispatchers";
GO

GRANT EXECUTE ON "AirCompanySelect" TO "Dispatchers";
GO

GRANT EXECUTE ON "CountriesSelect" TO "Dispatchers";
GO

GRANT EXECUTE ON "GetCountry" TO "Dispatchers";
GO

GRANT EXECUTE ON "SelectCitiesList" TO "Dispatchers";
GO

GRANT EXECUTE ON "GetCity" TO "Dispatchers";
GO

GRANT EXECUTE ON "SelectAirPortList" TO "Dispatchers";
GO

GRANT EXECUTE ON "GetAirport" TO "Dispatchers";
GO

--Менеджери авіакомпаній
GRANT EXECUTE ON "SelectFlights" TO "AircompanyManager";
GO

GRANT EXECUTE ON "GetFlight" TO "AircompanyManager";
GO

GRANT EXECUTE ON "InsertFlight" TO "AircompanyManager";
GO

GRANT EXECUTE ON "UpdateFlight" TO "AircompanyManager";
GO

GRANT EXECUTE ON "DeleteFlight" TO "AircompanyManager";
GO

GRANT EXECUTE ON "SelectAirplaneList"  TO "AircompanyManager";
GO

GRANT EXECUTE ON "GetPlane" TO "AircompanyManager";
GO

GRANT EXECUTE ON "UpdatePlane" TO "AircompanyManager";
GO

GRANT EXECUTE ON "InsertPlane" TO "AircompanyManager";
GO

GRANT EXECUTE ON "DeletePlane" TO "AircompanyManager";
GO

GRANT EXECUTE ON "AirCompanySelect" TO "AircompanyManager";
GO

GRANT EXECUTE ON "CountriesSelect" TO "AircompanyManager";
GO

GRANT EXECUTE ON "GetCountry" TO "AircompanyManager";
GO

GRANT EXECUTE ON "SelectCitiesList" TO "AircompanyManager";
GO

GRANT EXECUTE ON "GetCity" TO "AircompanyManager";
GO

GRANT EXECUTE ON "SelectAirPortList" TO "AircompanyManager";
GO

GRANT EXECUTE ON "GetAirport" TO "AircompanyManager";
GO

--Покупці
GRANT EXECUTE ON "SelectFlights" TO "TicketBuyer";
GO

GRANT EXECUTE ON "GetFlight" TO "TicketBuyer";
GO