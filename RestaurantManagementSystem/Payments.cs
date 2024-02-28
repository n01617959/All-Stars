using System;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Payments : Form
    {
        private EmployeeBLL employeeBLL; // Add EmployeeBLL field
        private bool isAdmin;

        public Payments(EmployeeBLL employeeBLL,bool isAdmin) // Pass EmployeeBLL as a parameter in constructor
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
            this.isAdmin = isAdmin;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(employeeBLL); // Pass the EmployeeBLL parameter
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Fast Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Void Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Void Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Add Gift Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Pay Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Receiptsummarycs receiptsummarycs = new Receiptsummarycs(isAdmin);
            receiptsummarycs.Show();
            this.Hide();
        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }
    }
}
