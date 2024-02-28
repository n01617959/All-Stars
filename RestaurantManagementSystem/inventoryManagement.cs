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

        public inventoryManagement()
        {
            InitializeComponent();
            InitializeDataGridView();
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
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            // inventoryManagement inventory = new inventoryManagement(employeeBLL); // Pass the EmployeeBLL parameter
            //inventory.Show();
            //this.Close();
            Form2 form2 = new Form2(employeeBLL); // Pass the EmployeeBLL parameter
            form2.Show();
            this.Close();
        }

        private void inventoryManagement_Load(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

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


