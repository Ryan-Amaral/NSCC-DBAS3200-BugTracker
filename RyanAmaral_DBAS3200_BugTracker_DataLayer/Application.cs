using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanAmaral_DBAS3200_BugTracker_DataLayer
{
    public class Application
    {
        private int _appID = -1; // def val
        private string _appName;
        private string _appVersion;
        private string _appDesc;

        public int AppID
        {
            get
            {
                return _appID;
            }

            set
            {
                _appID = value;
            }
        }
        public string AppName
        {
            get
            {
                return _appName;
            }

            set
            {
                _appName = value;
            }
        }
        public string AppVersion
        {
            get
            {
                return _appVersion;
            }

            set
            {
                _appVersion = value;
            }
        }
        public string AppDesc
        {
            get
            {
                return _appDesc;
            }

            set
            {
                _appDesc = value;
            }
        }

        public Application()
        {

        }

        public Application(int appId, string appName, string appVersion, string appDesc)
        {
            AppID = appId;
            AppName = appName;
            AppVersion = appVersion;
            AppDesc = appDesc;
        }

        /// <summary>
        /// Inserts app to the database if id is not set, else updates the record.
        /// </summary>
        public void Save()
        {
            // update
            if(AppID != -1)
            {
                string procedure = "UpdateApplication";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@appId", AppID);
                        command.Parameters.AddWithValue("@newAppName", AppName);
                        command.Parameters.AddWithValue("@newAppVersion", AppVersion);
                        command.Parameters.AddWithValue("@newAppDesc", AppDesc);
                        command.ExecuteNonQuery();
                    }
                }
            }
            // insert
            else
            {
                string procedure = "InsertApplication";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@appName", AppName);
                        command.Parameters.AddWithValue("@appVersion", AppVersion);
                        command.Parameters.AddWithValue("@appDesc", AppDesc);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// Returns true if user can be deleted. Deletes the user if can.
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            // delete
            if (AppID != -1)
            {
                string procedure = "DeleteApplication";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@appId", AppID);
                        command.Parameters.AddWithValue("@rows", 0);

                        command.ExecuteNonQuery();

                        return Applications.GetApplicationById(AppID) == null;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }

    public class Applications
    {
        public static List<Application> GetAllApplications()
        {
            List<Application> apps = new List<Application>();

            string procedure = "SelectAllApplications";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return application objects
                        while (reader.Read())
                        {
                            apps.Add(new Application(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                        }
                        return apps;
                    }
                }
            }
        }

        public static Application GetApplicationById(int id)
        {
            string procedure = "SelectApplicationById";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // if reader has a row, the user exists
                        if (reader.HasRows)
                        {
                            reader.Read(); // get first row of data
                            // fill in and return user object
                            return new Application(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                }
            }

            return null; // return null if all else fails
        }
    }
}
