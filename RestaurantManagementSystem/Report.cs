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
    public partial class Report : Form
    {
        private bool isAdmin;
        public Report(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();// Create an instance of EmployeeBLL
            if (isAdmin)
            {
                AdminDashboard adminDashboard = new AdminDashboard(employeeBLL);
                adminDashboard.Show();
            }
            else
            {
                Form2 form2 = new Form2(employeeBLL); // Pass the EmployeeBLL parameter
                form2.Show();
            }
            this.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
