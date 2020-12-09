using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportLib;
using System.Data.Odbc;
using System.Data;


namespace AirportLib
{
    public class Aircompany
    {
        private string connectionString = "";
        public int AircompanyID { set; get; } = 0;
        public string AircompanyName { set; get; } = "";
        public string AircompanyPhone { set; get; } = "";
        public string AircompanyAddress { set; get; } = "";

        private string ConnectionString
        {
            get
            {
                Config c = new Config();
                return c.ConnectionString;
            }
        }

        public void InsertNewAircompany()
        {
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = this.ConnectionString;
            cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL AircompanyInsert (?,?,?)}";

            cm.Parameters.Add(new OdbcParameter("@AirсompanyName", AircompanyName));
            cm.Parameters.Add(new OdbcParameter("@AirсompanyPhone", AircompanyPhone));
            cm.Parameters.Add(new OdbcParameter("@AirсompanyAddress", AircompanyAddress));

            cm.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }

        public void UpdateAircompany()
        {
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = this.ConnectionString;
            cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{CALL AircompanyUpdate (?,?,?,?)}";

            cm.Parameters.Add(new OdbcParameter("@AirсompanyName", AircompanyName));
            cm.Parameters.Add(new OdbcParameter("@AirсompanyPhone", AircompanyPhone));
            cm.Parameters.Add(new OdbcParameter("@AirсompanyAddress", AircompanyAddress));
            cm.Parameters.Add(new OdbcParameter("@AirсompanyID", AircompanyID));

            cm.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }

        public void DeleteAircompany()
        {
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = this.ConnectionString;
            cn.Open();

            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{CALL AircompanyDelete (?)}";

            cm.Parameters.Add(new OdbcParameter("@AirсompanyID", AircompanyID));

            cm.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }
    }
}
