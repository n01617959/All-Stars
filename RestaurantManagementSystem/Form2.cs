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
        private EmployeeBLL employeeBLL; // Add EmployeeBLL field

        public Form2(EmployeeBLL employeeBLL) // Pass EmployeeBLL as a parameter in constructor
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
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
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(employeeBLL);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders(employeeBLL); // Pass employeeBLL to Orders constructor
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
            inventoryManagement inventory = new inventoryManagement();
            inventory.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagementForm = new StaffManagement(employeeBLL); // Pass employeeBLL to StaffManagement constructor
            staffManagementForm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders(employeeBLL); // Pass employeeBLL to Orders constructor
            orders.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagementForm = new StaffManagement(employeeBLL); // Pass employeeBLL to StaffManagement constructor
            staffManagementForm.Show();
            this.Close();
        }
    }
}
