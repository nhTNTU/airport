using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class Flight
    {
        public OdbcException e { set; get; } = null;
        public int FlightID { set; get; } = 0;
        public int FlightAircompanyID { set; get; } = 0;
        public int FlightPlaneID { set; get; } = 0;
        public int FlightAirPortID { set; get; } = 0;
        public string FlightAircompanyName { set; get; } = "";
        public string FlightPlaneModel { set; get; } = "";
        public string FlightAirportName { set; get; } = "";
        public string FlightCityName { set; get; } = "";
        public string FlightCountryName { set; get; } = "";
        public string FlightType { set; get; } = "";
        public string FlightStatus { set; get; } = "";
        public DateTime FlightDateTimeStart { set; get; } = Convert.ToDateTime("1900-01-01 00:00:00");
        public string FlightDuration{ set; get; } = "00:00:00";
        public DateTime FlightDateTimeArrival { set; get; } = Convert.ToDateTime("1900-01-01 00:00:00");
        public DateTime FlightPeriodicity { set; get; } = Convert.ToDateTime("1900-01-01 00:00:00");
        public int FlightNumOfFlights { set; get; } = 0;
        public decimal FlightPriceEconom { set; get; } = 0.00m;
        public decimal FlightPriceBusiness { set; get; } = 0.00m;
        public decimal FlightPriceFirst { set; get; } = 0.00m;
        public DateTime FlightFilterBeginDate { set; get; } = Convert.ToDateTime("1900-01-01");
        public DateTime FlightFilterEndDate { set; get; } = Convert.ToDateTime("2050-01-01");
        public DateTime FlightDateTimeStartGMT { set; get; } = Convert.ToDateTime("1900-01-01 00:00:00");
        public DateTime FlightDateTimeArrivalGMT { set; get; } = Convert.ToDateTime("1900-01-01 00:00:00");

        public void GetFlight(int FlightID)
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL GetFlight (?)}";
            cm.Parameters.Add(new OdbcParameter("FlightID", FlightID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    this.FlightID = (int)dr["fl_id"];
                    FlightAircompanyID = (int)dr["fl_airc_id_FK"];
                    FlightPlaneID = (int)dr["fl_pln_id_FK"];
                    FlightAirPortID = (int)dr["fl_airP_id_FK"];
                    FlightType = dr["fl_type"].ToString();
                    FlightDateTimeStart = (DateTime)dr["fl_dateTimeStart"];
                    FlightDuration = dr["Duration"].ToString();
                    FlightDateTimeArrival = (DateTime)dr["fl_dateTimeArrival"];
                    //FlightDateTimeStartGMT = (DateTime)dr["fl_dateTimeStartGMT"];
                    //FlightDateTimeArrivalGMT = (DateTime)dr["fl_dateTimeArrivalGMT"];
                    FlightPriceEconom = (decimal)dr["fl_priceEconom"];
                    FlightPriceBusiness = (decimal)dr["fl_priceBusiness"];
                    FlightPriceFirst = (decimal)dr["fl_priceFirst"];
                    FlightStatus = dr["fl_status"].ToString();
                }
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
        }

        public void InsertFlight()
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL InsertFlight (?,?,?,?,?,?,?,?,?,?,?)}";
            DateTime _durationForInsert = Convert.ToDateTime("1900-01-01 " + FlightDuration);
            cm.Parameters.Add(new OdbcParameter("FlightAircompanyID", FlightAircompanyID));
            cm.Parameters.Add(new OdbcParameter("FlightPlaneID", FlightPlaneID));
            cm.Parameters.Add(new OdbcParameter("FlightAirPortID", FlightAirPortID));
            cm.Parameters.Add(new OdbcParameter("FlightType", FlightType));
            cm.Parameters.Add(new OdbcParameter("FlightDateTimeStart", FlightDateTimeStart));
            cm.Parameters.Add(new OdbcParameter("FlightDuration", FlightDuration));
            cm.Parameters.Add(new OdbcParameter("FlightNumOfFlights", FlightNumOfFlights));
            cm.Parameters.Add(new OdbcParameter("FlightPeriodicity", FlightPeriodicity));
            cm.Parameters.Add(new OdbcParameter("FlightPriceEconom", FlightPriceEconom));
            cm.Parameters.Add(new OdbcParameter("FlightPriceBusiness", FlightPriceBusiness));
            cm.Parameters.Add(new OdbcParameter("FlightPriceFirst", FlightPriceFirst));
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
        }

        public void EditFlight()
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL UpdateFlight (?,?,?,?,?,?,?,?,?,?)}";
            DateTime _durationForUpdate = Convert.ToDateTime("1900-01-01 " + FlightDuration);
            cm.Parameters.Add(new OdbcParameter("FlightID", FlightID));
            cm.Parameters.Add(new OdbcParameter("FlightAircompanyID", FlightAircompanyID));
            cm.Parameters.Add(new OdbcParameter("FlightPlaneID", FlightPlaneID));
            cm.Parameters.Add(new OdbcParameter("FlightAirPortID", FlightAirPortID));
            cm.Parameters.Add(new OdbcParameter("FlightType", FlightType));
            cm.Parameters.Add(new OdbcParameter("FlightDateTimeStart", FlightDateTimeStart));
            cm.Parameters.Add(new OdbcParameter("FlightDuration", FlightDuration));
            cm.Parameters.Add(new OdbcParameter("FlightPriceEconom", FlightPriceEconom));
            cm.Parameters.Add(new OdbcParameter("FlightPriceBusiness", FlightPriceBusiness));
            cm.Parameters.Add(new OdbcParameter("FlightPriceFirst", FlightPriceFirst));
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
        }

        public void DeleteFlight()
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL DeleteFlight (?)}";
            cm.Parameters.Add(new OdbcParameter("FlightID", FlightID));
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
        }
    }
}
