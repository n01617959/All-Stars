using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class EmployeeBLL
    {
        private EmployeeDAL employeeDAL;

        public EmployeeBLL()
        {
            this.employeeDAL = new EmployeeDAL();
        }

        public bool EmployeeExists(int id)
        {
            return employeeDAL.EmployeeExists(id);
        }

        public void AddEmployee(int id, string name, string gender, string contactNumber, string position)
        {
            employeeDAL.AddEmployee(id, name, gender, contactNumber, position);
        }

        public void DeleteEmployee(int id)
        {
            employeeDAL.DeleteEmployee(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeDAL.UpdateEmployee(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }

        public Employee GetEmployeeByID(int id)
        {
            return employeeDAL.GetEmployeeByID(id);
        }

        public bool isContactValid(string contact)
        {
            int number;
            bool isNumber = int.TryParse(contact, out number);

            if (isNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
