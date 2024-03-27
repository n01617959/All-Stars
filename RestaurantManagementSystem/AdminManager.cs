/*using System;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public class AdminManager
    {
        private readonly DatabaseManager _databaseManager;

        public AdminManager(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public bool ValidateAdmin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_databaseManager.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM admin_table WHERE username = @Username AND password = @Password";
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
                Console.WriteLine("Error validating admin: " + ex.Message);
                return false;
            }
        }
    }
}


*/