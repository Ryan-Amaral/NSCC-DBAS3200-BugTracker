using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanAmaral_DBAS3200_BugTracker_DataLayer
{
    public class DB
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["BugTrackerConnection"].ToString();

        public static SqlConnection ConnectToDB()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
