using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanAmaral_DBAS3200_BugTracker_DataLayer
{
    public class BugLog
    {
        private int _bugLogId;
        private DateTime _bugLogDate;
        private int _statusCodeId;
        private int _userId;
        private string _bugLogDesc;
        private int _bugId;

        public int BugLogId
        {
            get
            {
                return _bugLogId;
            }

            set
            {
                _bugLogId = value;
            }
        }
        public DateTime BugLogDate
        {
            get
            {
                return _bugLogDate;
            }

            set
            {
                _bugLogDate = value;
            }
        }
        public int StatusCodeId
        {
            get
            {
                return _statusCodeId;
            }

            set
            {
                _statusCodeId = value;
            }
        }
        public string StatusCodeName
        {
            get
            {
                return StatusCodes.GetStatusCodeById(StatusCodeId).StatusCodeDesc;
            }
        }
        public int UserId
        {
            get
            {
                return _userId;
            }

            set
            {
                _userId = value;
            }
        }
        public string UserName
        {
            get
            {
                return Users.GetUserById(UserId).UserName;
            }
        }
        public string BugLogDesc
        {
            get
            {
                return _bugLogDesc;
            }

            set
            {
                _bugLogDesc = value;
            }
        }
        public int BugId
        {
            get
            {
                return _bugId;
            }

            set
            {
                _bugId = value;
            }
        }
        

        public BugLog()
        {

        }

        public BugLog(int bugLogId, DateTime bugLogDate, int statusCodeId, int userId, string bugLogDesc, int bugId)
        {
            BugLogId = bugLogId;
            BugLogDate = bugLogDate;
            StatusCodeId = statusCodeId;
            UserId = userId;
            BugLogDesc = bugLogDesc;
            BugId = bugId;
        }

        /// <summary>
        /// Adds a new bug log into the database.
        /// </summary>
        public void Save()
        {
            string procedure = "InsertBugLog";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@bugLogDate", BugLogDate);
                    command.Parameters.AddWithValue("@statusCodeId", StatusCodeId);
                    command.Parameters.AddWithValue("@userId", UserId);
                    command.Parameters.AddWithValue("@bugLogDesc", BugLogDesc);
                    command.Parameters.AddWithValue("@bugId", BugId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class BugLogs
    {
        public static List<BugLog> GetBugLogsByBugId(int id)
        {
            List<BugLog> bugLogs = new List<BugLog>();

            string procedure = "SelectBugLogsWithBug";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@bugId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return bug objects
                        while (reader.Read())
                        {
                            bugLogs.Add(new BugLog(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), 
                                reader.GetInt32(3), reader.GetString(4), reader.GetInt32(5)));
                        }
                        return bugLogs;
                    }
                }
            }
        }
    }
}
