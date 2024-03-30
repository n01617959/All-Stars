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
            //if user select sales sales from the combo box and click on the generate report button it should list details from bills list
            if (comboBox1.Text == "Sales")
            {
                //Get the whole list of bills which is in billDb
                BillDB billDB = new BillDB();

                List<Bill> bills = billDB.GetAllBills();

                //Display the list of bills in the data grid view
                foreach (var bill in bills)
                {
                    dataGridView1.Rows.Add(bill.Item_No,bill.Category ,bill.Sub_category, bill.Price);
                }
            }
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
