using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanAmaral_DBAS3200_BugTracker_DataLayer
{
    public class StatusCode
    {
        public enum Codes { Unassigned = 1, InProgress = 2, ReadyForReview = 3, Closed = 4 };

        private int _statusCodeId = -1; // def val
        private string _statusCodeDesc;

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
        public string StatusCodeDesc
        {
            get
            {
                return _statusCodeDesc;
            }

            set
            {
                _statusCodeDesc = value;
            }
        }

        public StatusCode()
        {

        }

        public StatusCode(int statusCodeId, string statusCodeDesc)
        {
            StatusCodeId = statusCodeId;
            StatusCodeDesc = statusCodeDesc;
        }
    }

    public class StatusCodes
    {
        public static List<StatusCode> GetAllStatusCodes()
        {
            List<StatusCode> sCodes = new List<StatusCode>();

            string procedure = "SelectAllStatusCodes";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return StatusCode objects
                        while (reader.Read())
                        {
                            sCodes.Add(new StatusCode(reader.GetInt32(0), reader.GetString(1)));
                        }
                        return sCodes;
                    }
                }
            }
        }

        public static StatusCode GetStatusCodeById(int id)
        {
            StatusCode sCode = new StatusCode();

            string procedure = "SelectStatusCodeById";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codeId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // fill in and return StatusCode objects
                        while (reader.Read())
                        {
                            sCode = new StatusCode(reader.GetInt32(0), reader.GetString(1));
                        }
                        return sCode;
                    }
                }
            }
        }
    }
}
