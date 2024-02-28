using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class EmployeeDAL
    {
        private List<Employee> employees;

        public EmployeeDAL()
        {
            employees = new List<Employee>();
            // You may initialize or load data from a database or other storage here.
        }

        public bool EmployeeExists(int id)
        {
            return employees.Exists(emp => emp.ID == id);
        }

        public void AddEmployee(int id, string name, string gender, string contactNumber, string position)
        {
            employees.Add(new Employee(id, name, gender, contactNumber, position));
        }

        public void DeleteEmployee(int id)
        {
            employees.RemoveAll(emp => emp.ID == id);
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            int index = employees.FindIndex(emp => emp.ID == updatedEmployee.ID);
            if (index != -1)
            {
                employees[index] = updatedEmployee;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeByID(int id)
        {
            return employees.Find(emp => emp.ID == id);
        }
    }
}
