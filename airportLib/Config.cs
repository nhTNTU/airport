using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace AirportLib
{
    public class Config
    {
        public string connectionString = "Driver={SQL Server}; Server=DESKTOP-3ELKPK0\\WATSON; id = NazarHolub; Database = AirPortDB; password=root; sslmode=None;";

        public string ConnectionString
        {
            get
            {
                OdbcConnectionStringBuilder str = new OdbcConnectionStringBuilder();
                str.Add("Driver", "SQL Server");
                str.Add("Server", @"DESKTOP-3ELKPK0\WATSON");
                //str.Driver = "SQL Server";
                //str["Server"] = @"watson";
                //str.Add("Dbq", @"watson\daskayne");
                str.Add("Database", "AirPortDB");
                str.Add("Integrated Security", "no");
                str.Add("Uid", "NazarHolub");
                str.Add("Pwd", "root");
                return str.ToString();
            }
        }

        bool _integrSec = false;
        string _login = "";
        string _pass = "";
        string _error = "";

        public bool IntegratedSecurity
        {
            get
            {
                return UserSettings.Default.IntegratedSecurity;
            }
            set
            {
                _integrSec = value;
                UserSettings.Default.IntegratedSecurity = value;
            }
        }

        public string Login
        {
            get
            {
                return UserSettings.Default.Login;
            }
            set
            {
                _login = value;
                UserSettings.Default.Login = value;

            }
        }

        public string Password
        {
            get
            {
                return UserSettings.Default.Password;
            }
            set
            {
                UserSettings.Default.Password = value;
            }
        }

        public string ErrorString
        {
            get
            {
                return _error;
            }
        }

        public string ConnectString
        {
            get
            {
                OdbcConnectionStringBuilder str = new OdbcConnectionStringBuilder();
                str.Add("Driver", "SQL Server");
                str.Add("Server", @"DESKTOP-3ELKPK0\WATSON");
                //str.Driver = "SQL Server";
                //str["Server"] = UserSettings.Default.ServerName;
                //str.Add("Dbq", UserSettings.Default.ServerName + @"\" + UserSettings.Default.DBEngineName);
                str.Add("Database", "AirPortDB");
                str.Add("Integrated Security", "no");
                str.Add("Uid", UserSettings.Default.Login);
                str.Add("Pwd", UserSettings.Default.Password);
                return str.ToString();
            }
        }

        public bool TryToConnect(bool Remember)
        {
            bool _connectionState = false;
            OdbcConnection cn = new OdbcConnection();
            cn.ConnectionString = this.ConnectString;
            try
            {
                cn.Open();
                cn.Close();
                _connectionState = true;
                if (Remember == true)
                    UserSettings.Default.Save();
            }
            catch (OdbcException ex)
            {
                _error = "#: " + ex.ErrorCode + " Повідомлення: " + ex.Message;
                _connectionState = false;
            }

            return _connectionState;
        }

        public static bool HasUserAccess(string StoredProcedureName)
        {
            
            OdbcConnection cn = new OdbcConnection();
            Config cfg = new Config();
            cn.ConnectionString = cfg.ConnectString;
            OdbcCommand cm = cn.CreateCommand();
            cm.CommandText = "SELECT * FROM sys.procedures WHERE name NOT LIKE 'sp_%' AND name = '" + StoredProcedureName + "';";

            try
            {
                cn.Open();
                OdbcDataReader dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (OdbcException)
            {
                return false;
            }
        }

        public static void ForgetSettings()
        {
            UserSettings.Default.Reset();
        }
    }
}
