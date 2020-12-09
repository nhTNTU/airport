using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class AircompaniesList : List<Aircompany>
    {
        public static AircompaniesList GetDefaultAircompaniesList()
        {
            Config config = new Config();
            string connectionString = config.ConnectionString;
            OdbcConnection connection = new OdbcConnection();

            connection.ConnectionString = connectionString;
            connection.Open();

            OdbcCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AircompanySelect";

            OdbcDataReader dr = command.ExecuteReader();

            AircompaniesList acList = new AircompaniesList();

            while (dr.Read())
            {
                Aircompany newAirсompany = new Aircompany();
                newAirсompany.AircompanyID = Convert.ToInt32(dr["airc_id"]);
                newAirсompany.AircompanyName = dr["airc_name"].ToString();
                newAirсompany.AircompanyPhone = dr["airc_phone"].ToString();
                newAirсompany.AircompanyAddress = dr["airc_adress"].ToString();
                acList.Add(newAirсompany);
            }

            connection.Close();
            connection.Dispose();
            return acList;
        }

        public static AircompaniesList GetRefAircompaniesList()
        {
            Config config = new Config();
            string connectionString = config.ConnectionString;
            OdbcConnection connection = new OdbcConnection();

            connection.ConnectionString = connectionString;
            connection.Open();

            OdbcCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SelectRefAircompaniesList";

            OdbcDataReader dr = command.ExecuteReader();

            AircompaniesList acList = new AircompaniesList();

            while (dr.Read())
            {
                Aircompany newAirсompany = new Aircompany();
                newAirсompany.AircompanyID = Convert.ToInt32(dr["airc_id"]);
                newAirсompany.AircompanyName = dr["airc_name"].ToString();
                acList.Add(newAirсompany);
            }

            connection.Close();
            connection.Dispose();
            return acList;
        }
    }
}
