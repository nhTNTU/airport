using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class PlaneList : List<Plane>
    {
        public static PlaneList GetDefaultPlanesList()
        {
            PlaneList plist = new PlaneList();
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectAirplaneList";
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    Plane i = new Plane();
                    i.PlaneAircompanyID = (int)dr["pln_airc_id_FK"];
                    i.PlaneAircompanyName = dr["airc_name"].ToString();
                    i.PlaneID = (int)dr["pln_id"];
                    i.PlaneModel = dr["pln_model"].ToString();
                    i.PlaneNumber = dr["pln_number"].ToString();
                    plist.Add(i);
                }
            }
            catch (OdbcException)
            {
                return null;
                throw;
            }
            return plist;
        }

        public static PlaneList GetRefPlanesList()
        {
            OdbcConnection cn = new OdbcConnection();
            PlaneList pl = new PlaneList();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectRefPlaneList";

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    Plane pi = new Plane();
                    pi.PlaneID = (int)dr["pln_id"];
                    pi.PlaneNumber = dr["PlaneName"].ToString();
                    pl.Add(pi);
                }
                return pl;
            }
            catch (OdbcException)
            {
                return null;
            }
        }
    }
}
