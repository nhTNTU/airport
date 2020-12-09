using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class Plane
    {
        public OdbcException e { set; get; } = null;
        public int PlaneID { set; get; } = 0;
        public int PlaneAircompanyID { set; get; } = 0;
        public string PlaneModel { set; get; } = "";
        public string PlaneNumber { set; get; } = "";
        public string PlaneAircompanyName { set; get; } = "";


        public void GetPlane(int PlaneID)
        {
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL GetPlaneInfo (?)}";
            cm.Parameters.Add(new OdbcParameter("PlaneID", PlaneID));
            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    this.PlaneID = (int)dr["pln_id"];
                    PlaneAircompanyID = (int)dr["pln_airc_id_FK"];
                    PlaneModel = dr["pln_model"].ToString();
                    PlaneNumber = dr["pln_number"].ToString();
                }
            }
            catch (OdbcException ex)
            {
                e = ex;
            }
        }

        public void UpdatePlane()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL UpdatePlane (?,?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("PlaneID", PlaneID));
            cm.Parameters.Add(new OdbcParameter("PlaneAircompanyID", PlaneAircompanyID));
            cm.Parameters.Add(new OdbcParameter("PlaneModel", PlaneModel));
            cm.Parameters.Add(new OdbcParameter("PlaneNumber", PlaneNumber));
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

        public void InsertPlane()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL InsertPlane (?,?,?)}";
            cm.Parameters.Add(new OdbcParameter("PlaneAircompanyID", PlaneAircompanyID));
            cm.Parameters.Add(new OdbcParameter("PlaneModel", PlaneModel));
            cm.Parameters.Add(new OdbcParameter("PlaneNumber", PlaneNumber));
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

        public void DeletePlane()
        {
            Config cfg = new Config();
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = cfg.ConnectionString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "{ CALL DeletePlane (?)}";
            cm.Parameters.Add(new OdbcParameter("PlaneID", PlaneID));
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
