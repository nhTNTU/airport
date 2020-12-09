using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class FlightList : List<Flight>
    {
        public static FlightList GetAllFlights()
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectFlights";
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?)}";
            cm.Parameters.Add(new OdbcParameter("BeginDate", DateTime.Today));
            cm.Parameters.Add(new OdbcParameter("EndDate", EndDate));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(DateTime BeginDate, DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?)}";
            cm.Parameters.Add(new OdbcParameter("BeginDate", BeginDate));
            cm.Parameters.Add(new OdbcParameter("EndDate", EndDate));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }


        }

        //country
        public static FlightList GetAllFlights(int CountryID)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights  (?)}";
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(int CountryID, DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("BeginDate", DateTime.Today));
            cm.Parameters.Add(new OdbcParameter("EndDate", EndDate));
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(int CountryID, DateTime BeginDate, DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?,?)}";
            
            cm.Parameters.Add(new OdbcParameter("BeginDate", BeginDate));
            cm.Parameters.Add(new OdbcParameter("EndDate", EndDate));
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException ex)
            {
                return null;
            }
        }

        //country and city
        public static FlightList GetAllFlights(int CountryID, int CityID)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?)}";
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("CityID", CityID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(int CountryID, int CityID, DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("BeginDate", DateTime.Today));
            cm.Parameters.Add(new OdbcParameter("EndDate", EndDate));
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("CityID", CityID));

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(int CountryID, int CityID, DateTime BeginDate, DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("BeginDate", BeginDate));
            cm.Parameters.Add(new OdbcParameter("EndDate", EndDate));
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("CityID", CityID));

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }


        //country, city and airport
        public static FlightList GetAllFlights(int CountryID, int CityID, int AirportID)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("CityID", CityID));
            cm.Parameters.Add(new OdbcParameter("AirportID", AirportID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(int CountryID, int CityID, int AirportID, DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("CityID", CityID));
            cm.Parameters.Add(new OdbcParameter("AirportID", AirportID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }

        public static FlightList GetAllFlights(int CountryID, int CityID, int AirportID, DateTime BeginDate, DateTime EndDate)
        {
            FlightList flist = new FlightList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL SelectFlights (?,?,?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("BeginDate", BeginDate));
            cm.Parameters.Add(new OdbcParameter("EndDate", EndDate));
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("CityID", CityID));
            cm.Parameters.Add(new OdbcParameter("AirportID", AirportID));

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                flist = ReadFromOdbcDataReader(dr);
                return flist;
            }
            catch (OdbcException)
            {
                return null;
            }
        }


        public static FlightList ReadFromOdbcDataReader(OdbcDataReader dr)
        {
            FlightList fl = new FlightList();
            while (dr.Read())
            {
                Flight f = new Flight();
                f.FlightID = (int)dr["fl_id"];
                f.FlightAircompanyID = (int)dr["fl_airc_id_FK"];
                f.FlightPlaneID = (int)dr["fl_pln_id_FK"];
                f.FlightAirPortID = (int)dr["fl_airP_id_FK"];
                f.FlightType = dr["fl_type"].ToString();
                f.FlightDateTimeStart = (DateTime)dr["fl_dateTimeStart"];
                f.FlightDuration = dr["Duration"].ToString();
                f.FlightDateTimeArrival = (DateTime)dr["fl_dateTimeArrival"];
                f.FlightPriceEconom = (decimal)dr["fl_priceEconom"];
                f.FlightPriceBusiness = (decimal)dr["fl_priceBusiness"];
                f.FlightPriceFirst = (decimal)dr["fl_priceFirst"];
                //f.FlightDateTimeStartGMT = (DateTime)dr["fl_dateTimeStartGMT"];
                //f.FlightDateTimeArrivalGMT = (DateTime)dr["fl_dateTimeArrivalGMT"];
                f.FlightStatus = dr["fl_status"].ToString();
                f.FlightAircompanyName = dr["airc_name"].ToString();
                f.FlightPlaneModel = dr["pln_model"].ToString();
                f.FlightAirportName = dr["AirPortName"].ToString();
                f.FlightCityName = dr["CityName"].ToString();
                f.FlightCountryName = dr["CountryName"].ToString();
                fl.Add(f);
            }
            return fl;
        }
    }
}
