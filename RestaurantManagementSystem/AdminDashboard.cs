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
    public partial class AdminDashboard : Form
    {
        private EmployeeBLL employeeBLL;
        private bool isAdmin = true;
        public AdminDashboard(EmployeeBLL employeeBLL)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(employeeBLL);
            adminDashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventoryManagement inventory = new inventoryManagement(isAdmin);
            inventory.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagementForm = new StaffManagement(employeeBLL,isAdmin); // Pass employeeBLL to StaffManagement constructor
            staffManagementForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report(isAdmin);
            report.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Log out", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            inventoryManagement inventory = new inventoryManagement(isAdmin);
            inventory.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagementForm = new StaffManagement(employeeBLL, isAdmin); // Pass employeeBLL to StaffManagement constructor
            staffManagementForm.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Report report = new Report(isAdmin);
            report.Show();
            this.Close();
        }
    }
}
