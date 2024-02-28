﻿using System;
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
                    EmployeeBLL employeeBLL = new EmployeeBLL(); // Instantiate EmployeeBLL
                    new Form2(employeeBLL).Show(); // Pass EmployeeBLL instance to Form2 constructor
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
