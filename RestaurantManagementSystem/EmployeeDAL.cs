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
            foreach (var emp in employees)
            {
                if (emp.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddEmployee(int id, string name, string gender, string contactNumber, string position)
        {
            employees.Add(new Employee(id, name, gender, contactNumber, position));
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == id)
                {
                    employees.RemoveAt(i);
                    return;
                }
            }
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == updatedEmployee.ID)
                {
                    employees[i] = updatedEmployee;
                    return;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeByID(int id)
        {
            foreach (var emp in employees)
            {
                if (emp.ID == id)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
