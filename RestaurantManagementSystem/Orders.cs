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
    public partial class Orders : Form
    {
        private EmployeeBLL employeeBLL; // Add field for EmployeeBLL
        private bool isAdmin;
        private InventoryManager inventoryManager = new InventoryManager();


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
            Payments payments = new Payments(employeeBLL,isAdmin); 
            payments.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            foreach (var selected in listBox1.SelectedItems)
            {
                var item = inventoryManager.GetSubCategoriesByCategory("Dosa").FirstOrDefault(i => i.ItemName == selected.ToString());
                if (item != null)
                {
                    var index = dataGridView_selectedItems.Rows.Add();
                    dataGridView_selectedItems.Rows[index].Cells["Category"].Value = item.Category;
                    dataGridView_selectedItems.Rows[index].Cells["SubCategory"].Value = item.ItemName;
                    dataGridView_selectedItems.Rows[index].Cells["Price"].Value = item.Price;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_selectedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
