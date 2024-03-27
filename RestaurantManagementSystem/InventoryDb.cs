using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public class InventoryDb
    {
        // Updated with your provided connection string
        private string connectionString = "Server=LAPTOP-EITE4OAK;Database=MasterDB;Trusted_Connection=True;";

        public void AddInventory(Inventory inventory)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO items (Sub_category, Category, Price, Quantity, Description) 
                                 VALUES (@ItemName, @Category, @Price, @Quantity, @Description)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", inventory.ItemName);
                    command.Parameters.AddWithValue("@Category", inventory.Category);
                    command.Parameters.AddWithValue("@Price", inventory.Price);
                    command.Parameters.AddWithValue("@Quantity", inventory.Quantity);
                    command.Parameters.AddWithValue("@Description", inventory.Description);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Inventory item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdateInventory(Inventory inventory)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE items SET Sub_category = @ItemName, Category = @Category, 
                                 Price = @Price, Quantity = @Quantity, Description = @Description WHERE Item_No = @ItemID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemID", inventory.ItemID);
                    command.Parameters.AddWithValue("@ItemName", inventory.ItemName);
                    command.Parameters.AddWithValue("@Category", inventory.Category);
                    command.Parameters.AddWithValue("@Price", inventory.Price);
                    command.Parameters.AddWithValue("@Quantity", inventory.Quantity);
                    command.Parameters.AddWithValue("@Description", inventory.Description);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Inventory item not found for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void RemoveInventory(int itemID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM items WHERE Item_No = @ItemID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemID", itemID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Inventory item not found for delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public List<Inventory> GetSubCategoriesByCategory(string category)
        {
            List<Inventory> subCategories = new List<Inventory>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Item_No, Sub_category, Category, Price, Quantity, Description FROM items WHERE Category = @Category";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Category", category);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subCategories.Add(new Inventory(
    Convert.ToInt32(reader["Item_No"]),
    reader["Sub_category"].ToString(),
    Convert.ToInt32(reader["Quantity"]), // Moved to correct position
    reader["Category"].ToString(), // Correct position
    Convert.ToDecimal(reader["Price"]), // Correct position
    reader["Description"].ToString() 
));
                        }
                    }
                }
            }
            return subCategories;
        }




        public List<Inventory> GetInventory()
        {
            List<Inventory> inventoryList = new List<Inventory>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Item_No, Sub_category, Quantity,Category, Price,  Description FROM items";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Inventory inventory = new Inventory(
                                Convert.ToInt32(reader["Item_No"]),
                                reader["Sub_category"].ToString(),
                                Convert.ToInt32(reader["Quantity"]),
                                reader["Category"].ToString(),
                                Convert.ToDecimal(reader["Price"]),
                                reader["Description"].ToString()
                            );
                            inventoryList.Add(inventory);
                        }
                    }
                }
            }
            return inventoryList;
        }
    }
}
