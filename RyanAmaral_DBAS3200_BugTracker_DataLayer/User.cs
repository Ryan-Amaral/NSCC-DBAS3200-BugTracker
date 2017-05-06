using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanAmaral_DBAS3200_BugTracker_DataLayer
{
    /// <summary>
    /// The object of a user.
    /// </summary>
    public class User
    {
        private int _userId = -1;
        private string _userName;
        private string _userEmail;
        private string _userTel;

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
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }
        public string UserEmail
        {
            get
            {
                return _userEmail;
            }

            set
            {
                _userEmail = value;
            }
        }
        public string UserTel
        {
            get
            {
                return _userTel;
            }

            set
            {
                _userTel = value;
            }
        }

        public User() { }

        /// <summary>
        /// Constructor to make object with all of the fields.
        /// </summary>
        public User(int userId, string userName, string userEmail, string userTel)
        {
            UserId = userId;
            UserName = userName;
            UserEmail = userEmail;
            UserTel = userTel;
        }

        /// <summary>
        /// Inserts user to the database if id is not set, else updates the record.
        /// </summary>
        public void Save()
        {
            // update
            if (UserId != -1)
            {
                string procedure = "UpdateUser";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userId", UserId);
                        command.Parameters.AddWithValue("@newUserName", UserName);
                        command.Parameters.AddWithValue("@newUserEmail", UserEmail);
                        command.Parameters.AddWithValue("@newUserTel", UserTel);
                        command.ExecuteNonQuery();
                    }
                }
            }
            // insert
            else
            {
                string procedure = "InsertUser";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userName", UserName);
                        command.Parameters.AddWithValue("@userEmail", UserEmail);
                        command.Parameters.AddWithValue("@userTel", UserTel);
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
            if (UserId != -1)
            {
                string procedure = "DeleteUser";

                using (SqlConnection connection = DB.ConnectToDB())
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userId", UserId);
                        command.Parameters.AddWithValue("@success", 0);
                        command.Parameters.AddWithValue("@rows1", 0);
                        command.Parameters.AddWithValue("@rows2", 0);

                        command.ExecuteNonQuery();

                        return Users.GetUserById(UserId) == null;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }

    /// <summary>
    /// The general user class when not currently dealing with a specific user.
    /// </summary>
    public class Users
    {
        /// <summary>
        /// Gets a single user by the user name.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static User GetUserByUserName(string userName)
        {
            string userProcedure = "SelectUserByUserName";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(userProcedure, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userName", userName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // if reader has a row, the user exists
                        if (reader.HasRows)
                        {
                            reader.Read(); // get first row of data
                            // fill in and return user object
                            return new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                }
            }

            return null; // return null if all else fails
        }

        public static User GetUserById(int id)
        {
            string userProcedure = "SelectUserById";

            using (SqlConnection connection = DB.ConnectToDB())
            {
                using (SqlCommand command = new SqlCommand(userProcedure, connection))
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
                            return new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                }
            }

            return null; // return null if all else fails
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            string procedure = "SelectAllUsers";

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
                            users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                        }
                        return users;
                    }
                }
            }
        }
    }
}
