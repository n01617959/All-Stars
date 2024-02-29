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
    public partial class StaffManagement : Form
    {
        private EmployeeBLL employeeBLL;
        public SalaryForm salaryForm;
        private bool isAdmin;
        public StaffManagement(EmployeeBLL employeeBLL, bool isAdmin)
        {
            InitializeComponent();
            this.employeeBLL = employeeBLL;
            InitializeListView();
            this.isAdmin = isAdmin;
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            if (employeeBLL != null)
            {
                UpdateListView();
            }
        }
        private void InitializeListView()
        {
            listViewEmployees.Columns.Add("ID", 60);
            listViewEmployees.Columns.Add("Name", 150);
            listViewEmployees.Columns.Add("Gender", 65);
            listViewEmployees.Columns.Add("Contact Number", 150);
            listViewEmployees.Columns.Add("Position", 70);
            listViewEmployees.FullRowSelect = true;
            UpdateListView();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textID.Text);
                string name = TxtName.Text;
                string gender = cmbGender.SelectedItem.ToString();
                string contactNumber = txtContact.Text;
                string position = txtPosition.Text;
                if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender) ||
                    string.IsNullOrWhiteSpace(contactNumber) ||
                    string.IsNullOrWhiteSpace(position))
                {
                    MessageBox.Show("Please enter information in all textboxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(!employeeBLL.isContactValid(contactNumber))
                {
                    MessageBox.Show("Please enter numbers between 0-9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (employeeBLL.EmployeeExists(id))
                {
                    MessageBox.Show("Employee with the same ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                employeeBLL.AddEmployee(id, name, gender, contactNumber, position);
                UpdateListView();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewEmployees.SelectedItems)
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    employeeBLL.DeleteEmployee(id);
                }
                UpdateListView();
            }
            else
                MessageBox.Show("Please select an item!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                try
                {
                    int selectedIndex = listViewEmployees.SelectedIndices[0];
                    Employee selectedEmployee = employeeBLL.GetEmployeeByID(selectedIndex + 1);
                    selectedEmployee.Name = TxtName.Text;
                    selectedEmployee.Gender = cmbGender.SelectedItem.ToString();
                    selectedEmployee.ContactNumber =  employeeBLL.isContactValid(txtContact.Text)?
                        txtContact.Text : selectedEmployee.ContactNumber;
                    selectedEmployee.Position = txtPosition.Text;
                    employeeBLL.UpdateEmployee(selectedEmployee);
                    UpdateListView();
                }
                catch
                {
                    MessageBox.Show("Please Enter all fields");
                }
            }
            else
                MessageBox.Show("Please select an item!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void UpdateListView()
        {
            listViewEmployees.Items.Clear();
            List<Employee> employees = employeeBLL.GetAllEmployees();
            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.ID.ToString());
                item.SubItems.Add(emp.Name);
                item.SubItems.Add(emp.Gender);
                item.SubItems.Add(emp.ContactNumber);
                item.SubItems.Add(emp.Position);
                listViewEmployees.Items.Add(item);
            }
        }

        private void ClearFields()
        {
            textID.Text = "";
            TxtName.Text = "";
            cmbGender.SelectedIndex = -1;
            txtContact.Text = "";
            txtPosition.Text = "";
        }

       
        private void btnOpenSalaryForm_Click(object sender, EventArgs e)
        {
            salaryForm = new SalaryForm(this, employeeBLL,isAdmin); 
            salaryForm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                AdminDashboard adminDashboard = new AdminDashboard(employeeBLL);
                adminDashboard.Show();
                this.Hide();
            }
            else
            {
                Form2 form2 = new Form2(employeeBLL); 
                form2.Show();
                this.Hide();
            }
        }
    }
}
