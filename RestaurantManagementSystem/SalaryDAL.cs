using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class SalaryDAL
    {
        private List<EmployeeSalary> salary;
        public static List<EmployeeSalary> Salary = new List<EmployeeSalary>();

        public SalaryDAL()
        {
            salary = Salary;
        }

        public void addSalary(EmployeeSalary employeeSalary)
        {
            Salary.Add(employeeSalary);

        }
        public void updateSalary(EmployeeSalary employeeSalary)
        {
            Salary.Remove(Salary.FirstOrDefault(x => x.EmployeeID == employeeSalary.EmployeeID));
            Salary.Add(employeeSalary);
        }
    }
}
