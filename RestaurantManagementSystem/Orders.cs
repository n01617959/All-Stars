using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Orders : Form
    {
        private EmployeeBLL employeeBLL; // Add field for EmployeeBLL
        private bool isAdmin;
        private InventoryManager inventoryManager = new InventoryManager();
        private BillManager billManager = new BillManager();
        private List<Bill> checkoutItems = new List<Bill>();
        public bool DosaClicked = false;
        public bool BeveragesClicked = false;
        public bool DessertsClicked = false;
        public bool SoupsClicked = false;
        public bool BiryaniClicked = false;
        public bool ChefSpecialClicked = false;


        public Orders(EmployeeBLL employeeBLL, bool isAdmin) // Constructor to accept EmployeeBLL
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL; // Assign the passed EmployeeBLL to the field
            this.isAdmin = isAdmin;

            InitializeDataGridViewColumns();

        }


        private void InitializeDataGridViewColumns()
        {
            if (dataGridView_selectedItems.Columns.Count == 0)
            {
                dataGridView_selectedItems.Columns.Add("Category", "Category");

                dataGridView_selectedItems.Columns.Add("SubCategory", "Sub Category");

                dataGridView_selectedItems.Columns.Add("Price", "Price");
            }
        }

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DosaClicked = true;
            listBox1.Items.Clear();
            var items = inventoryManager.GetSubCategoriesByCategory("Dosa");
            foreach (var item in items)
            {
                listBox1.Items.Add(item.ItemName); 
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(checkoutItems,employeeBLL, isAdmin);
            payments.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //have to display the subtotal , hst, total
            decimal subtotal = 0;
            decimal hst = 0;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView_selectedItems.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["Price"].Value);
            }
            hst = subtotal * 0.10m;
            total = subtotal + hst;

            textBox1.Text = subtotal.ToString();
            textBox2.Text = hst.ToString();
            textBox3.Text = total.ToString();

            //add the gridviewlist items to bill table no need to select
            foreach (var item in checkoutItems)
            {
                item.Sub_Total = subtotal;
                item.HST = hst;
                item.Total = total;
                billManager.AddBill(item);
            }
            MessageBox.Show("Bill added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear the gridview
            dataGridView_selectedItems.Rows.Clear();
            listBox1.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remove the selected item from the gridview
            if (dataGridView_selectedItems.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Are you sure you want to delete this item?","Alert",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    dataGridView_selectedItems.Rows.RemoveAt(dataGridView_selectedItems.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }


        }

        private void label14_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(employeeBLL); // Pass the EmployeeBLL parameter
            form.Show();
            this.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {


        }

        private void add_items_Click(object sender, EventArgs e)
        {
            //add the selected item to the gridview
            if (DosaClicked)
            {
                var item = inventoryManager.GetSubCategoriesByCategory("Dosa");
                foreach (var items in item)
                {
                    dataGridView_selectedItems.Rows.Add(items.Category, items.ItemName, items.Price);
                }
                //add the selected item to the checkoutItems list
                foreach (var items in item)
                {
                    checkoutItems.Add(new Bill(items.ItemID, items.ItemName, items.Category, items.Price,0, 0, 0));
                }
                DosaClicked = false;
            }
            else if(BeveragesClicked)
            {
                var item = inventoryManager.GetSubCategoriesByCategory("Beverages");
                foreach (var items in item)
                {
                    dataGridView_selectedItems.Rows.Add(items.Category, items.ItemName, items.Price);
                }
                foreach (var items in item)
                {
                    checkoutItems.Add(new Bill(items.ItemID, items.ItemName, items.Category, items.Price, 0, 0, 0));
                }
                BeveragesClicked = false;
            }
            else if (DessertsClicked)
            {
                var item = inventoryManager.GetSubCategoriesByCategory("Desserts");
                foreach (var items in item)
                {
                    dataGridView_selectedItems.Rows.Add(items.Category, items.ItemName, items.Price);
                }
                foreach (var items in item)
                {
                    checkoutItems.Add(new Bill(items.ItemID, items.ItemName, items.Category, items.Price, 0, 0, 0));
                }
                DessertsClicked = false;
            }
            else if (SoupsClicked)
            {
                var item = inventoryManager.GetSubCategoriesByCategory("Soups");
                foreach (var items in item)
                {
                    dataGridView_selectedItems.Rows.Add(items.Category, items.ItemName, items.Price);
                }
                foreach (var items in item)
                {
                    checkoutItems.Add(new Bill(items.ItemID, items.ItemName, items.Category, items.Price, 0, 0, 0));
                }
                SoupsClicked = false;
            }
            else if (BiryaniClicked)
            {
                var item = inventoryManager.GetSubCategoriesByCategory("Biryani");
                foreach (var items in item)
                {
                    dataGridView_selectedItems.Rows.Add(items.Category, items.ItemName, items.Price);
                }
                foreach (var items in item)
                {
                    checkoutItems.Add(new Bill(items.ItemID, items.ItemName, items.Category, items.Price, 0, 0, 0));
                }
                BiryaniClicked = false;
            }
            else if (ChefSpecialClicked)
            {
                var item = inventoryManager.GetSubCategoriesByCategory("Chef Special");
                foreach (var items in item)
                {
                    dataGridView_selectedItems.Rows.Add(items.Category, items.ItemName, items.Price);
                }
                ChefSpecialClicked = false;
            }   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_selectedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void lblBeverages_Click(object sender, EventArgs e)
        {
            BeveragesClicked = true;
            listBox1.Items.Clear();
            var items = inventoryManager.GetSubCategoriesByCategory("Beverages");
            foreach (var item in items)
            {
                listBox1.Items.Add(item.ItemName);
            }
        }

        private void lbl_Desserts_Click(object sender, EventArgs e)
        {
            DessertsClicked = true;
            listBox1.Items.Clear();
            var items = inventoryManager.GetSubCategoriesByCategory("Desserts");
            foreach (var item in items)
            {
                listBox1.Items.Add(item.ItemName);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            SoupsClicked = true;
            listBox1.Items.Clear();
            var items = inventoryManager.GetSubCategoriesByCategory("Soups");
            foreach (var item in items)
            {
                listBox1.Items.Add(item.ItemName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            BiryaniClicked = true;
            listBox1.Items.Clear();
            var items = inventoryManager.GetSubCategoriesByCategory("Biryani");
            foreach (var item in items)
            {
                listBox1.Items.Add(item.ItemName);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChefSpecialClicked = true;
            listBox1.Items.Clear();
            var items = inventoryManager.GetSubCategoriesByCategory("Chef Special");
            foreach (var item in items)
            {
                listBox1.Items.Add(item.ItemName);
            }
        }

    }
}
