using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public enum UserType
    {
        None,
        User,
        Admin
    }

    public class DatabaseManager
    {
        public string ConnectionString { get; }

        public DatabaseManager(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public UserType ValidateCredentials(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Check in admin_table
                    string query = "SELECT COUNT(*) FROM admin_table WHERE username = @Username AND password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Consider hashing in a real application
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            return UserType.Admin;
                        }
                    }

                    // Check in user_table
                    query = "SELECT COUNT(*) FROM user_table WHERE username = @Username AND password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Consider hashing in a real application
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            return UserType.User;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error validating credentials: {ex.Message}");
            }

            return UserType.None;
        }

        // Method to connect to the database
        public void ConnectToDatabase()
        {
            try
            {
                // Establish database connection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Display message box when connected
                    MessageBox.Show("Connected to the database successfully!", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Display error message if connection fails
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool StoreLogin(string username, string password)
        {
            // Dummy implementation
            // In a real application, you'd store a login token or session, not the raw credentials
            return true;
        }
    }
}
