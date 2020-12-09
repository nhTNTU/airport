using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class AirPortList : List<AirPort>
    {
        public static OdbcException e { set; get; } = null;

        public static AirPortList GetDefaultAirPortList()
        {
            AirPortList myAirPortList = new AirPortList();
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectAirPortList";
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    AirPort air = new AirPort();
                    air.AirPortID = (int)dr["airP_id"];
                    air.AirPortName = dr["airP_name"].ToString();
                    air.AirPortCityName = dr["city_name"].ToString();
                    air.AirPortCountryName = dr["cntr_name"].ToString();
                    myAirPortList.Add(air);
                }
            }
            catch (OdbcException ex)
            {
                e = ex;
            }

            return myAirPortList;
        }

        public static AirPortList GetRefAirportListByCity(int AirPortCityID)
        {
            AirPortList al = new AirPortList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{CALL SelectRefAirportListByCity (?)}";
            cm.Parameters.Add(new OdbcParameter("@AirPortCityID", AirPortCityID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    AirPort ap = new AirPort();
                    ap.AirPortID = (int)dr["airP_id"];
                    ap.AirPortName = dr["airP_name"].ToString();
                    al.Add(ap);
                }
                return al;
            }
            catch (OdbcException)
            {
                return null;
            }
        }
    }
}