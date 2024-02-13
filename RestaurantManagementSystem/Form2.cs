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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Log out", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventoryManagement inventory = new inventoryManagement();
            inventory.Show();
            
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagementForm;
            staffManagementForm = new StaffManagement();
            staffManagementForm.Show();
            this.Close();
        }
    }
}
