using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class AirPort
    {
        public OdbcException e { set; get; } = null;
        public int AirPortID { set; get; } = 0;
        public int AirPortCityID { set; get; } = 0;
        public string AirPortName { set; get; } = "";
        public string AirPortCityName { set; get; } = "";
        public string AirPortCountryName { set; get; } = "";

        public void GetAirport(int AirPortID)
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{CALL GetAirPort (?)}";
            cm.Parameters.Add(new OdbcParameter("@AirportID", AirPortID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    this.AirPortID = (int)dr["airP_id"];
                    AirPortCityID = (int)dr["airP_city_id_FK"];
                    AirPortName = dr["airP_name"].ToString();
                }
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
        }
 
        public void DeleteAirport()
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{CALL DeleteAirPort (?)}";
            cm.Parameters.Add(new OdbcParameter("@AirPortID", AirPortID));
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

        public void UpdateAirport()
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL UpdateAirPort (?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("@AirPortID", AirPortID));
            cm.Parameters.Add(new OdbcParameter("@AirPortName", AirPortName));
            cm.Parameters.Add(new OdbcParameter("@AirPortCityID", AirPortCityID));
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

        public void InsertAirport()
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{CALL InsertAirPort (?,?)}";
            cm.Parameters.Add(new OdbcParameter("@AirPortName", AirPortName));
            cm.Parameters.Add(new OdbcParameter("@AirPortCityID", AirPortCityID));
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
