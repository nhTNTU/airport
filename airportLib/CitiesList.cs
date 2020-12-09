using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using AirportLib;

namespace AirportLib
{
    public class CitiesList : List<City>
    {
        public static CitiesList GetDefaultCitiesList()
        {
            CitiesList cList = new CitiesList();
            Config config = new Config();

            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = config.ConnectionString;
            cn.Open();
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectCitiesList";
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                City info = new City();
                info.CityID = Convert.ToInt32(dr["city_id"]);
                info.CountryID = (int)dr["city_cntr_id_FK"];
                info.CityName = dr["city_name"].ToString();
                info.CitySignGMT = dr["city_signGMT"].ToString();
                info.CityGMT = Convert.ToDateTime(dr["city_GMT"]);

                cList.Add(info);
            }
            cn.Close();
            cn.Dispose();
            return cList;
        }

        public static CitiesList GetCitiesListByCountry(int CountryID)
        {
            CitiesList cl = new CitiesList();
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL RefSelectCitiesListByID (?)}";
            cm.Parameters.Add(new OdbcParameter("CountryID", CountryID));

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    City qq = new City();
                    qq.CityID = (int)dr["city_id"];
                    qq.CityName = dr["city_name"].ToString();
                    cl.Add(qq);
                }
            }
            catch (OdbcException ex)
            {
                throw ex;
            }

            return cl;
        }
    }
}
