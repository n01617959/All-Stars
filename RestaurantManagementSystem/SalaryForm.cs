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
    public partial class SalaryForm : Form
    {
        private StaffManagement staffManagementForm;
        private List<EmployeeSalary> employeeSalaries = new List<EmployeeSalary>();
        private EmployeeBLL employeeBLL; // Define EmployeeBLL field

        public SalaryForm(StaffManagement staffManagementForm, EmployeeBLL employeeBLL)
        {
            InitializeComponent();
            this.staffManagementForm = staffManagementForm;
            this.employeeBLL = employeeBLL; // Initialize EmployeeBLL
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Add columns to the ListView
            listViewSalaries.Columns.Add("Employee ID", 80);
            listViewSalaries.Columns.Add("Salary Amount", 80);
            listViewSalaries.Columns.Add("Payment Date", 80);
            listViewSalaries.Columns.Add("Tax Percentage", 80);
        }


        private void SalaryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmployeeID.Text) || string.IsNullOrEmpty(txtSalaryAmount.Text) || cmbTaxPercentage.SelectedItem == null)
                {
                    MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = int.Parse(txtEmployeeID.Text);
                double salary = double.Parse(txtSalaryAmount.Text);
                DateTime paymentDate = dateTimePicker1.Value.Date;
                double taxPercentage = double.Parse(cmbTaxPercentage.SelectedItem.ToString());

                // Check for minimum salary
                if (salary < 16.5)
                {
                    MessageBox.Show("Salary cannot be less than $16.5!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add new salary
                employeeSalaries.Add(new EmployeeSalary(id, salary, paymentDate, taxPercentage));
                UpdateListView();
                //ClearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            // Update Salary
            if (listViewSalaries.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem selectedSalaryItem = listViewSalaries.SelectedItems[0];

                    var itemToUpdate = employeeSalaries.FirstOrDefault(x => x.EmployeeID == int.Parse(selectedSalaryItem.Text));
                    itemToUpdate.Salary = double.Parse(txtSalaryAmount.Text.ToString());
                    itemToUpdate.PaymentDate = dateTimePicker1.Value.Date;
                    itemToUpdate.TaxPercentage = double.Parse(cmbTaxPercentage.SelectedItem.ToString());

                    employeeSalaries.Remove(employeeSalaries.FirstOrDefault(x => x.EmployeeID == int.Parse(selectedSalaryItem.Text)));
                    employeeSalaries.Add(itemToUpdate);

                    UpdateListView();
                }
                catch
                {
                    MessageBox.Show("Please enter valid information to update!");
                }
            }
            else
                MessageBox.Show("Please select an item!");

        }

        private void btnCalculateGrossSalary_Click(object sender, EventArgs e)
        {
            // Calculate Gross Salary
            if (listViewSalaries.SelectedItems.Count > 0)
            {
                ListViewItem selectedSalaryItem = listViewSalaries.SelectedItems[0];
                double grossSalary = double.Parse(selectedSalaryItem.SubItems[1].Text) * (1 - double.Parse(selectedSalaryItem.SubItems[3].Text) / 100);
                MessageBox.Show($"Gross Salary: {grossSalary}", "Gross Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select an item!");
        }

        private void UpdateListView()
        {
            listViewSalaries.Items.Clear();
            foreach (EmployeeSalary salary in employeeSalaries)
            {
                ListViewItem item = new ListViewItem(salary.EmployeeID.ToString());
                item.SubItems.Add(salary.Salary.ToString());
                item.SubItems.Add(salary.PaymentDate.ToShortDateString());
                item.SubItems.Add(salary.TaxPercentage.ToString());
                listViewSalaries.Items.Add(item);
            }
        }


        private void ClearFields()
        {
            txtEmployeeID.Text = "";
            txtSalaryAmount.Text = "";
            cmbTaxPercentage.SelectedIndex = -1;
        }

        private void LoadEmployees()
        {
             employeeBLL.GetAllEmployees();
            // Populate your controls with employee data
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Salary Form
            StaffManagement staffManagementForm = new StaffManagement();
            staffManagementForm.Show();
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void listViewSalaries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }
    }
}
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class SalaryForm : Form
    {
        private readonly StaffManagement staffManagementForm;
        private readonly EmployeeBLL employeeBLL;
        private readonly List<EmployeeSalary> employeeSalaries = new List<EmployeeSalary>();

        public SalaryForm(StaffManagement staffManagementForm, EmployeeBLL employeeBLL)
        {
            InitializeComponent();
            this.staffManagementForm = staffManagementForm;
            this.employeeBLL = employeeBLL;
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Add columns to the ListView
            listViewSalaries.Columns.Add("Employee ID", 80);
            listViewSalaries.Columns.Add("Salary Amount", 80);
            listViewSalaries.Columns.Add("Payment Date", 80);
            listViewSalaries.Columns.Add("Tax Percentage", 80);
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmployeeID.Text) || string.IsNullOrEmpty(txtSalaryAmount.Text) || cmbTaxPercentage.SelectedItem == null)
                {
                    MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = int.Parse(txtEmployeeID.Text);
                double salary = double.Parse(txtSalaryAmount.Text);
                DateTime paymentDate = dateTimePicker1.Value.Date;
                double taxPercentage = double.Parse(cmbTaxPercentage.SelectedItem.ToString());

                // Check for minimum salary
                if (salary < 16.5)
                {
                    MessageBox.Show("Salary cannot be less than $16.5!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add new salary
                employeeSalaries.Add(new EmployeeSalary(id, salary, paymentDate, taxPercentage));
                UpdateListView();
                //ClearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            // Update Salary
            if (listViewSalaries.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem selectedSalaryItem = listViewSalaries.SelectedItems[0];

                    var itemToUpdate = employeeSalaries.FirstOrDefault(x => x.EmployeeID == int.Parse(selectedSalaryItem.Text));
                    itemToUpdate.Salary = double.Parse(txtSalaryAmount.Text.ToString());
                    itemToUpdate.PaymentDate = dateTimePicker1.Value.Date;
                    itemToUpdate.TaxPercentage = double.Parse(cmbTaxPercentage.SelectedItem.ToString());

                    employeeSalaries.Remove(employeeSalaries.FirstOrDefault(x => x.EmployeeID == int.Parse(selectedSalaryItem.Text)));
                    employeeSalaries.Add(itemToUpdate);

                    UpdateListView();
                }
                catch
                {
                    MessageBox.Show("Please enter valid information to update!");
                }
            }
            else
                MessageBox.Show("Please select an item!");
        }

        private void btnCalculateGrossSalary_Click(object sender, EventArgs e)
        {
            // Calculate Gross Salary
            if (listViewSalaries.SelectedItems.Count > 0)
            {
                ListViewItem selectedSalaryItem = listViewSalaries.SelectedItems[0];
                double grossSalary = double.Parse(selectedSalaryItem.SubItems[1].Text) * (1 - double.Parse(selectedSalaryItem.SubItems[3].Text) / 100);
                MessageBox.Show($"Gross Salary: {grossSalary}", "Gross Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select an item!");
        }

        private void UpdateListView()
        {
            listViewSalaries.Items.Clear();
            foreach (EmployeeSalary salary in employeeSalaries)
            {
                ListViewItem item = new ListViewItem(salary.EmployeeID.ToString());
                item.SubItems.Add(salary.Salary.ToString());
                item.SubItems.Add(salary.PaymentDate.ToShortDateString());
                item.SubItems.Add(salary.TaxPercentage.ToString());
                listViewSalaries.Items.Add(item);
            }
        }

        private void ClearFields()
        {
            txtEmployeeID.Text = "";
            txtSalaryAmount.Text = "";
            cmbTaxPercentage.SelectedIndex = -1;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Salary Form
            staffManagementForm.Show();
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void listViewSalaries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(employeeBLL); // Pass the EmployeeBLL parameter
            form.Show();
            this.Close();
        }
    }
}
