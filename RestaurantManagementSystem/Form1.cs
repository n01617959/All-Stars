/*using System;
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
*/


using System;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly UserManager _userManager;

        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            _userManager = new UserManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter Credentials");
            }
            else
            {
                if (_userManager.ValidateUser(username, password))
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password you entered is incorrect, try again");
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
    }
}
