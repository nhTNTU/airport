using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class City
    {
        public OdbcException e { set; get; } = null;
        public int CityID { set; get; } = 0;
        public int CountryID { set; get; } = 0;
        public string CityName { set; get; } = "";
        public long CityPopulation { set; get; } = 0;
        public string CitySignGMT { set; get; } = "+";
        public DateTime CityGMT { set; get; } = new DateTime(1900, 1, 1);

        private string countryName = "";
        public string CountryName
        {
            get
            {
                Country country = new Country();
                country.GetCountry(CountryID);
                return country.CountryName;
            }
        }

        private string stringGMT = "";
        public string StringGMT
        {
            get
            {
                return CitySignGMT + CityGMT.ToString("HH:mm");
            }
        }

        public void InsertCity()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            //cn.Open();
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL CityInsert (?,?,?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("@CountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("@CityName", CityName));
            cm.Parameters.Add(new OdbcParameter("@CityPopulation", CityPopulation));
            cm.Parameters.Add(new OdbcParameter("@CityGMT", CityGMT));
            cm.Parameters.Add(new OdbcParameter("@CitySignGMT", CitySignGMT));
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
            cn.Close();
            cn.Dispose();
        }

        public void UpdateCity()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL CityUpdate (?,?,?,?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("@CityID", CityID));
            cm.Parameters.Add(new OdbcParameter("@CityCountryID", CountryID));
            cm.Parameters.Add(new OdbcParameter("@CityName", CityName));
            cm.Parameters.Add(new OdbcParameter("@CityPopulation", CityPopulation));
            cm.Parameters.Add(new OdbcParameter("@CityGMT", CityGMT));
            cm.Parameters.Add(new OdbcParameter("@CitySignGMT", CitySignGMT));

            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
            cn.Close();
            cn.Dispose();
        }

        public void GetCity(int CityID)
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            cn.Open();
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL GetCity (?)}";
            cm.Parameters.Add(new OdbcParameter("@CityID", CityID));
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                this.CityID = (int)dr["city_id"];
                CityName = dr["city_name"].ToString();
                CountryID = (int)dr["city_cntr_id_FK"];
                CityGMT = (DateTime)dr["city_GMT"];
                CitySignGMT = dr["city_SignGMT"].ToString();
                CityPopulation = (long)dr["city_population"];
            }
            cn.Close();
            cn.Dispose();
        }

        public void DeleteCity()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL CityDelete (?)}";
            cm.Parameters.Add(new OdbcParameter("@CityID", CityID));
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
            cn.Close();
            cn.Dispose();
        }
    }
}
