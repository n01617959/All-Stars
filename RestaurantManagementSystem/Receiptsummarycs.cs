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
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }
    }
}
