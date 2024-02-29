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
        private InventoryManager inventoryManager = new InventoryManager();
        private EmployeeBLL employeeBLL; // Add field for EmployeeBLL
        private bool isAdmin;

        public inventoryManagement(bool isAdmin)
        {
            InitializeComponent();
            InitializeDataGridView();
            this.isAdmin = isAdmin;
        }

        public inventoryManagement(EmployeeBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            inventoryGridView.Columns.Add("ItemID", "Item ID");
            inventoryGridView.Columns.Add("ItemName", "Item Name");
            inventoryGridView.Columns.Add("Quantity", "Quantity");
            inventoryGridView.Columns.Add("Category", "Category");
            inventoryGridView.Columns.Add("Price", "Price");
            inventoryGridView.Columns.Add("Description", "Description");

            // Handle cell click event to populate selected row in text fields
            inventoryGridView.CellClick += InventoryGridView_CellClick;
        }

        private void InventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < inventoryGridView.Rows.Count)
            {
                DataGridViewRow row = inventoryGridView.Rows[e.RowIndex];
                itemIDTextBox.Text = row.Cells["ItemID"].Value.ToString();
                itemNameTextBox.Text = row.Cells["ItemName"].Value.ToString();
                quantityTextBox.Text = row.Cells["Quantity"].Value.ToString();
                categoryTextBox.Text = row.Cells["Category"].Value.ToString();
                priceTextBox.Text = row.Cells["Price"].Value.ToString();
                descriptionTextBox.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                AdminDashboard adminDashboard = new AdminDashboard(employeeBLL);
                adminDashboard.Show();
            }
            else
            {
                Form2 form2 = new Form2(employeeBLL);
                form2.Show();
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (TryGetInputValues(out int itemID, out string itemName, out int quantity,
                                   out string category, out decimal price, out string description))
            {
                Inventory newInventory = new Inventory(itemID, itemName, quantity, category, price, description);
                inventoryManager.AddInventory(newInventory);

                UpdateDataGridView();
                ClearTextBoxes();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.CurrentRow != null && TryGetInputValues(out int itemID, out string itemName, out int quantity,
                                  out string category, out decimal price, out string description))
            {
                Inventory updatedInventory = new Inventory(itemID, itemName, quantity, category, price, description);
                inventoryManager.UpdateInventory(updatedInventory);

                UpdateDataGridView();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.CurrentRow != null)
            {
                int selectedRowIndex = inventoryGridView.CurrentRow.Index;
                int itemID = Convert.ToInt32(inventoryGridView.Rows[selectedRowIndex].Cells["ItemID"].Value);
                inventoryManager.RemoveInventory(itemID);

                UpdateDataGridView();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private bool TryGetInputValues(out int itemID, out string itemName, out int quantity,
                                 out string category, out decimal price, out string description)
        {
            itemID = 0;
            itemName = itemNameTextBox.Text.Trim();
            quantity = 0;
            category = categoryTextBox.Text.Trim();
            price = 0m;
            description = descriptionTextBox.Text.Trim();

            // Validate Item ID
            bool isItemIdValid = int.TryParse(itemIDTextBox.Text.Trim(), out itemID);
            if (!isItemIdValid || itemID < 0)
            {
                MessageBox.Show("Invalid Item ID. Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Item Name
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Item Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Quantity
            bool isQuantityValid = int.TryParse(quantityTextBox.Text.Trim(), out quantity);
            if (!isQuantityValid || quantity < 0)
            {
                MessageBox.Show("Invalid Quantity. Please enter a non-negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Category
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Category is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Price
            bool isPriceValid = decimal.TryParse(priceTextBox.Text.Trim(), out price);
            if (!isPriceValid || price < 0)
            {
                MessageBox.Show("Invalid Price. Please enter a non-negative value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Description is optional and requires no validation

            return true; // All inputs are valid
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

        private void UpdateDataGridView()
        {
            inventoryGridView.Rows.Clear();
            foreach (Inventory inventoryItem in inventoryManager.GetInventory())
            {
                inventoryGridView.Rows.Add(inventoryItem.ItemID, inventoryItem.ItemName, inventoryItem.Quantity,
                                           inventoryItem.Category, inventoryItem.Price, inventoryItem.Description);
            }
        }
    }
}
