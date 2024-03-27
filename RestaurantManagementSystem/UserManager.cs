/*using System;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public class UserManager
    {
        private readonly DatabaseManager _databaseManager;

        public UserManager(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public bool ValidateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_databaseManager.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM user_table WHERE username = @Username AND password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Consider hashing the password
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error validating user: " + ex.Message);
                return false;
            }
        }
    }
}
*/