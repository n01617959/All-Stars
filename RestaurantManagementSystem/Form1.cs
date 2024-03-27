using System;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly DatabaseManager _databaseManager;
        private readonly EmployeeBLL _employeeBLL; // Add this line

        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            _databaseManager = new DatabaseManager("Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;TrustServerCertificate=true;");
            _databaseManager.ConnectToDatabase();

            // Instantiate EmployeeBLL
            _employeeBLL = new EmployeeBLL(); // Instantiate as needed, pass necessary parameters if any
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
                UserType userType = _databaseManager.ValidateCredentials(username, password);

                if (userType != UserType.None)
                {
                    // Assuming StoreLogin just logs the attempt and always returns true for this example
                    _databaseManager.StoreLogin(username, password);

                    MessageBox.Show("Login Successful!");

                    // Open respective forms based on user type
                    if (userType == UserType.User)
                    {
                        // Open Orders form
                        Orders ordersForm = new Orders(_employeeBLL, false); // Assuming isAdmin parameter is false for regular users
                        ordersForm.Show();
                        MessageBox.Show("Welcome, User!");
                    }
                    else if (userType == UserType.Admin)
                    {
                        // Open AdminDashboard form
                        AdminDashboard adminDashboardForm = new AdminDashboard(_employeeBLL); // Assuming there's only one admin, so isAdmin parameter is not needed
                        adminDashboardForm.Show();
                        MessageBox.Show("Welcome, Admin!");
                    }
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
    }
}
