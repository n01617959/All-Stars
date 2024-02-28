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
    public partial class Receiptsummarycs : Form
    {
        public Receiptsummarycs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

            // Create an instance of Orders and show it
            EmployeeBLL employeeBLL = new EmployeeBLL(); // Create an instance of EmployeeBLL
            Orders orders = new Orders(employeeBLL); // Pass EmployeeBLL to Orders's constructor
            orders.Show();
        }
    }
}
