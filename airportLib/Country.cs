using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class Country
    {
        public int CountryID { set; get; } = 0;
        public string CountryName { set; get; } = "";

        public void InsertNewCountry()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL CountryInsert (?)}";

            cm.Parameters.Add(new OdbcParameter("@CountryName", CountryName));

            cm.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
        }

        public void UpdateCountry()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL CountryUpdate (?,?)}";

            cm.Parameters.Add(new OdbcParameter("@CountryName", CountryName));
            cm.Parameters.Add(new OdbcParameter("@CountryID", CountryID));

            cm.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
        }

        public void DeleteCountry()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            //cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL CountryDelete (?)}";

            cm.Parameters.Add(new OdbcParameter("@CountryID", CountryID));

            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
            }
            catch (Exception)
            {
            }
        }

        public void GetCountry(int CountryID)
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL GetCountry (?)}";

            cm.Parameters.Add(new OdbcParameter("@CountryID", CountryID));
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                this.CountryID = (int)dr["cntr_id"];
                CountryName = dr["cntr_name"].ToString();
            }

            cn.Close();
            cn.Dispose();
        }
    }
}
