using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HospitalManagementSystem.Entities;

namespace HospitalManagementSystem.DAL
{
    public class UserRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public User GetUserByCredentials(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";
            DataTable dt = _dbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new User
                {
                    UserId = (int)row["UserId"],
                    UserName = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
            }
            return null;
        }

        public User GetUserByUsername(string username)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username";
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserId = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        Password = reader.GetString(2),
                        Role = reader.GetString(3)
                    };
                }
                return null;
            }
        }
    }

    /*
     * public void AddUser(User user)
        {
            string query = $"INSERT INTO Users (Username, Password, Role) " +
                           $"VALUES ('{user.Username}', '{user.Password}', '{user.Role}')";
            _dbHelper.ExecuteNonQuery(query);
        }
    */
}
