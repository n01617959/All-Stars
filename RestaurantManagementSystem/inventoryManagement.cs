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
                inventoryGridView.Rows.Add(itemID, itemName, quantity, category, price, description);
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
                    selectedRow.Cells[0].Value = itemID;
                    selectedRow.Cells[1].Value = itemName;
                    selectedRow.Cells[2].Value = quantity;
                    selectedRow.Cells[3].Value = category;
                    selectedRow.Cells[4].Value = price;
                    selectedRow.Cells[5].Value = description;
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
                inventoryGridView.Rows.Remove(inventoryGridView.CurrentRow);
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
    }
}
