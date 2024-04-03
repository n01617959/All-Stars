using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Payments : Form
    {
        private EmployeeBLL employeeBLL; // Add EmployeeBLL field
        private bool isAdmin;

        private List<Bill> bills;


        public Payments(List<Bill> bills,EmployeeBLL employeeBLL,bool isAdmin) // Pass EmployeeBLL as a parameter in constructor
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
            this.isAdmin = isAdmin;
            this.bills = bills;
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
            /*Receiptsummarycs receiptsummarycs = new Receiptsummarycs(isAdmin);
            receiptsummarycs.Show();
            this.Hide();*/

            //show the details in grid box in messagebox
            string message = "";
            decimal total = 0;
            decimal hst = 0;
            foreach (var bill in bills)
            {
                message += $"Item No: {bill.Item_No}, Sub Category: {bill.Sub_category}, Price: {bill.Price}";
                message += Environment.NewLine;
                hst = bill.HST;
                total = bill.Total;
            }

            message += $"HST: {hst}";
            message += Environment.NewLine;
            message += $"Total: {total}";
            message += Environment.NewLine;

            MessageBox.Show(message, "Receipt Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal hst = 0;
            foreach (var bill in bills)
            {
                dataGridView1.Rows.Add(bill.Item_No, bill.Sub_category, bill.Price);
                hst = bill.HST;
                total = bill.Total;
            }

            int hstRowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[hstRowIndex].Cells[1].Value = "HST";
            dataGridView1.Rows[hstRowIndex].Cells[2].Value = hst;

            // Adding a row for Total
            int totalRowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[totalRowIndex].Cells[1].Value = "Total";
            dataGridView1.Rows[totalRowIndex].Cells[2].Value = total;

            // Optional: Format the HST and Total rows for emphasis
            foreach (var rowIndex in new[] { hstRowIndex, totalRowIndex })
            {
                dataGridView1.Rows[rowIndex].DefaultCellStyle.Font = new System.Drawing.Font(dataGridView1.Font, System.Drawing.FontStyle.Bold);
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                // Making sure the total and HST rows span multiple columns if necessary
                dataGridView1.Rows[rowIndex].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

        }
    }
}
