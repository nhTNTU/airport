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
    public class CountriesList : List<Country>
    {
        public static CountriesList GetDefaultCountriesList()
        {
            CountriesList cList = new CountriesList();

            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "CountriesSelect";

            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Country cInfo = new Country();
                cInfo.CountryID = Convert.ToInt32(dr["cntr_id"]);
                cInfo.CountryName = dr["cntr_name"].ToString();
                cList.Add(cInfo);
            }

            cn.Close();
            cn.Dispose();
            return cList;
        }

        public static CountriesList GetRefCountriesList()
        {
            CountriesList cl = new CountriesList();
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "RefCountriesSelect";
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    Country ci = new Country();
                    ci.CountryID = (int)dr["cntr_id"];
                    ci.CountryName = dr["cntr_name"].ToString();
                    cl.Add(ci);
                }
                return cl;
            }
            catch (OdbcException)
            {
                return null;
            }
        }
    }
}
