using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public  class Employee
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Position { get; set; }

        public  List<EmployeeSalary> employeeSalaries = new List<EmployeeSalary>();


        public Employee(int id, string name, string gender, string contactNumber, string position)
        {
            ID = id;
            Name = name;
            Gender = gender;
            ContactNumber = contactNumber;
            Position = position;
        }

        public override string ToString()
        {
            return $"{ID} - {Name} - {Gender} - {ContactNumber} - {Position}";
        }
    }
}
