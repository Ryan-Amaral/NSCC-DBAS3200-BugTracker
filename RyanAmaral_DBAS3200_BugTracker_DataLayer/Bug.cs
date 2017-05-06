using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanAmaral_DBAS3200_BugTracker_DataLayer
{
    public class Bug
    {
        public const int NULL_INT = -2; // need this null because bug sign off could be null but int can't

        private int _bugId = -1; // def val
        private int _appId;
        private int _userId;
        private int? _bugSignOff;
        private DateTime _bugDate;
        private string _bugDesc;
        private string _bugDetails;
        private string _repSteps;
        private DateTime? _fixDate;

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
        public int AppId
        {
            get
            {
                return _appId;
            }

            set
            {
                _appId = value;
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
        public int? BugSignOff
        {
            get
            {
                return _bugSignOff;
            }

            set
            {
                _bugSignOff = value;
            }
        }
        public DateTime BugDate
        {
            get
            {
                return _bugDate;
            }

            set
            {
                _bugDate = value;
            }
        }
        public string BugDesc
        {
            get
            {
                return _bugDesc;
            }

            set
            {
                _bugDesc = value;
            }
        }
        public string BugDetails
        {
            get
            {
                return _bugDetails;
            }

            set
            {
                _bugDetails = value;
            }
        }
        public string RepSteps
        {
            get
            {
                return _repSteps;
            }

            set
            {
                _repSteps = value;
            }
        }
        public DateTime? FixDate
        {
            get
            {
                return _fixDate;
            }

            set
            {
                _fixDate = value;
            }
        }
        public StatusCode CurStatus
        {
            get
            {
                return Bugs.GetBugCurrentStatus(BugId);
            }
        }

        public Bug()
        {

        }

        public Bug(int bugId, int appId, int userId, int? bugSignOff, DateTime bugDate, string bugDesc, string bugDetails, string repSteps, DateTime? fixDate)
        {
            BugId = bugId;
            AppId = appId;
            BugSignOff = bugSignOff;
            BugDate = bugDate;
            BugDesc = bugDesc;
            BugDetails = bugDetails;
            RepSteps = repSteps;
            FixDate = fixDate;
        }

        /// <summary>
        /// Inserts or updates the object in the database.
        /// </summary>
        public void Save()
        {
            // update
            if (BugId != -1)
            {
                string procedure = "UpdateBug";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@bugId", BugId);
                        if (BugSignOff == null) {
                            command.Parameters.AddWithValue("@newBugSignOff", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@newBugSignOff", BugSignOff);
                        }
                        command.Parameters.AddWithValue("@newBugDesc", BugDesc);
                        command.Parameters.AddWithValue("@newBugDetails", BugDetails);
                        command.Parameters.AddWithValue("@newRepSteps", RepSteps);
                        if (FixDate == null)
                        {
                            command.Parameters.AddWithValue("@newFixDate", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@newFixDate", FixDate);
                        }
                        command.ExecuteNonQuery();
                    }
                }
            }
            // insert
            else
            {
                string procedure = "InsertBug";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@appId", AppId);
                        command.Parameters.AddWithValue("@userId", UserId);
                        if (BugSignOff == null)
                        {
                            command.Parameters.AddWithValue("@bugSignOff", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@bugSignOff", BugSignOff);
                        }
                        command.Parameters.AddWithValue("@bugDate", BugDate);
                        command.Parameters.AddWithValue("@bugDesc", BugDesc);
                        command.Parameters.AddWithValue("@bugDetails", BugDetails);
                        command.Parameters.AddWithValue("@repSteps", RepSteps);
                        if (FixDate == null)
                        {
                            command.Parameters.AddWithValue("@fixDate", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fixDate", FixDate);
                        }
                        command.ExecuteNonQuery();
                        BugId = Bugs.GetNewestBugId();
                    }
                }
            }
        }

        /// <summary>
        /// Deletes the bug from the database.
        /// </summary>
        public void Delete()
        {
            // delete
            if (BugId != -1)
            {
                string procedure = "DeleteBug";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@bugId", BugId);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    public class Bugs
    {
        /// <summary>
        /// Returns all of the bugs that are on an app.
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public static List<Bug> GetAllBugsFromApp(int appId)
        {
            List<Bug> bugs = new List<Bug>();

            string procedure = "SelectAllBugsOnApp";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@appId", appId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return bug objects
                        while (reader.Read())
                        {
                            bugs.Add(new Bug(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (!reader.IsDBNull(3)) ? reader.GetInt32(3) : (int?)null, 
                                reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), (!reader.IsDBNull(8)) ? reader.GetDateTime(8) : (DateTime?)null));
                        }
                        return bugs;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all bugs of the certain status code that are on the app.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="statCodeId"></param>
        /// <returns></returns>
        public static List<Bug> GetAllBugsFromAppWithStatCode(int appId, int statCodeId)
        {
            List<Bug> bugs = new List<Bug>();

            string procedure = "SelectAllBugsOnAppWithStat";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@appId", appId);
                    command.Parameters.AddWithValue("@statId", statCodeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return bug objects
                        while (reader.Read())
                        {
                            bugs.Add(new Bug(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (!reader.IsDBNull(3)) ? reader.GetInt32(3) : (int?)null,
                                reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), (!reader.IsDBNull(8)) ? reader.GetDateTime(8) : (DateTime?)null));
                        }
                        return bugs;
                    }
                }
            }
        }

        public static StatusCode GetBugCurrentStatus(int bugId)
        {
            StatusCode code = new StatusCode();

            string procedure = "BugCurrentStatus";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@bugId", bugId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return bug objects
                        if (reader.Read())
                        {
                            code = new StatusCode(reader.GetInt32(0), reader.GetString(1));
                        }
                        return code;
                    }
                }
            }
        }

        public static int GetNewestBugId()
        {
            int newestBugId = 1;

            string procedure = "NewestBugId";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return bug objects
                        if (reader.Read())
                        {
                            newestBugId = reader.GetInt32(0);
                        }
                        return newestBugId;
                    }
                }
            }
        }
    }
}
