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

        public Orders(EmployeeBLL employeeBLL, bool isAdmin) // Constructor to accept EmployeeBLL
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL; // Assign the passed EmployeeBLL to the field
            this.isAdmin = isAdmin;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(employeeBLL,isAdmin); // Pass the EmployeeBLL parameter
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
    }
}
