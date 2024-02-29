using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public class SalaryBLL
    {
        private EmployeeDAL employeeDAL;

        private SalaryDAL salaryDAL;

        public SalaryBLL()
        {
            this.salaryDAL = new SalaryDAL();
            this.employeeDAL = new EmployeeDAL();
        }
        public bool addSalary(int id, double salary, DateTime paymentDate, double taxPercentage)
        {
            if(!employeeDAL.EmployeeExists(id))
            {
                return false;

            }
            if(SalaryDAL.Salary.Any(x => x.EmployeeID == id))
                return false;

            var emplSalary = new EmployeeSalary(id, salary, paymentDate, taxPercentage);
            salaryDAL.addSalary(emplSalary);
            return true;

        }

        public bool updateSalary(EmployeeSalary employeeSalary)
        {
            if (!SalaryDAL.Salary.Any(x => x.EmployeeID == employeeSalary.EmployeeID))
                return false;

            salaryDAL.updateSalary(employeeSalary);
            return true;
        }
    }
}
