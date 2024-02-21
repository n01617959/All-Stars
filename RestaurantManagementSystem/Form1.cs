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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text =="" || txtPassword.Text =="")
            {
                MessageBox.Show("Enter Credentials");
            }
            else 
            {
                if (txtUserName.Text == "Allstars" && txtPassword.Text == "123")
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password you enetred is incorrect, try again");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
