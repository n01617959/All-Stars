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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
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
            
            Receiptsummarycs receiptsummarycs = new Receiptsummarycs();
            receiptsummarycs.Show();
            this.Hide();
        }
    }
}
