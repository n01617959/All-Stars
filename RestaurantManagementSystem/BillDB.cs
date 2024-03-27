using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public class BillDB
    {
        // Updated with your provided connection string
        private string connectionString = "Server=LAPTOP-EITE4OAK;Database=MasterDB;Trusted_Connection=True;";

        //CREATE TABLE Bills(Item_No INT IDENTITY(1,1),Sub_category VARCHAR(50),Category VARCHAR(50) select * FROM items;, Price DECIMAL(10, 2),Sub_Total DECIMAL(10, 2),HST DECIMAL(10, 2),Total DECIMAL(10, 2));

        public void AddBill(Bill bill)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Bills (Sub_category, Category, Price, Sub_Total, HST, Total) 
                                 VALUES (@Sub_category, @Category, @Price, @Sub_Total, @HST, @Total)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sub_category", bill.Sub_category);
                    command.Parameters.AddWithValue("@Category", bill.Category);
                    command.Parameters.AddWithValue("@Price", bill.Price);
                    command.Parameters.AddWithValue("@Sub_Total", bill.Sub_Total);
                    command.Parameters.AddWithValue("@HST", bill.HST);
                    command.Parameters.AddWithValue("@Total", bill.Total);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Bill added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    
    }
}
    