using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class inventoryManagement : Form
    {
        private InventoryDb inventoryDb = new InventoryDb();
        public inventoryManagement()
        {
            InitializeComponent();
            inventoryGridView.Columns.Add("ItemID", "Item ID");
            inventoryGridView.Columns.Add("ItemName", "Item Name");
            inventoryGridView.Columns.Add("Quantity", "Quantity");
            inventoryGridView.Columns.Add("Category", "Category");
            inventoryGridView.Columns.Add("Price", "Price");
            inventoryGridView.Columns.Add("Description", "Description");
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void inventoryManagement_Load(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (TryGetInputValues(out int itemID, out string itemName, out int quantity,
                              out string category, out double price, out string description))
            {
                Inventory newInventory = new Inventory(itemID, itemName, quantity, category, price, description);
                inventoryDb.AddInventory(newInventory);

                UpdateDataGridView();
                ClearTextBoxes();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.CurrentRow != null)
            {
                if (TryGetInputValues(out int itemID, out string itemName, out int quantity,
                                      out string category, out double price, out string description))
                {
                    DataGridViewRow selectedRow = inventoryGridView.CurrentRow;

                    // Create an updated Inventory object
                    Inventory updatedInventory = new Inventory(itemID, itemName, quantity, category, price, description);

                    // Update the Inventory in the list
                    inventoryDb.UpdateInventory(updatedInventory);

                    // Update the DataGridView
                    UpdateDataGridView();

                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.CurrentRow != null)
            {
                int selectedRowIndex = inventoryGridView.CurrentRow.Index;

                // Get the ItemID of the selected row
                int selectedItemId = (int)inventoryGridView.Rows[selectedRowIndex].Cells[0].Value;

                // Remove the inventory from the list
                inventoryDb.RemoveInventory(selectedItemId);

                // Update the DataGridView to reflect the changes in the list
                UpdateDataGridView();

                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private bool TryGetInputValues(out int itemID, out string itemName, out int quantity,
                               out string category, out double price, out string description)
        {
            itemID = 0;
            itemName = itemNameTextBox.Text;
            quantity = 0;
            category = categoryTextBox.Text;
            price = 0;
            description = descriptionTextBox.Text;

            if (int.TryParse(itemIDTextBox.Text, out int parsedItemID))
            {
                itemID = parsedItemID;
            }
            else
            {
                MessageBox.Show("Invalid Item ID. Please enter a valid integer.");
                return false;
            }

            if (int.TryParse(quantityTextBox.Text, out int parsedQuantity))
            {
                quantity = parsedQuantity;
            }
            else
            {
                MessageBox.Show("Invalid Quantity. Please enter a valid integer.");
                return false;
            }

            if (double.TryParse(priceTextBox.Text, out double parsedPrice))
            {
                price = parsedPrice;
            }
            else
            {
                MessageBox.Show("Invalid Price. Please enter a valid number.");
                return false;
            }

            if (itemID == 0 || itemName == "" || quantity == 0 || category == "" || price == 0 || description == "")
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }

            return true;
        }

        private void ClearTextBoxes()
        {
            itemIDTextBox.Text = "";
            itemNameTextBox.Text = "";
            quantityTextBox.Text = "";
            categoryTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDataGridView()
        {
            // Clear existing rows
            inventoryGridView.Rows.Clear();

            // Add rows based on the current state of the inventory list
            foreach (Inventory inventoryItem in inventoryDb.GetInventory())
            {
                AddInventoryRowToDataGridView(inventoryItem);
            }
        }

        private void AddInventoryRowToDataGridView(Inventory inventoryItem)
        {
            inventoryGridView.Rows.Add(
                inventoryItem.ItemID,
                inventoryItem.ItemName,
                inventoryItem.Quantity,
                inventoryItem.Category,
                inventoryItem.Price,
                inventoryItem.Description
            );
        }
    }
}
