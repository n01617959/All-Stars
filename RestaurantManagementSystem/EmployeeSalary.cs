using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class EmployeeSalary
    {
        public int EmployeeID { get; set; }
        public double Salary { get; set; }
        public DateTime PaymentDate { get; set; }
        public double TaxPercentage { get; set; }

        public EmployeeSalary(int employeeID, double salary, DateTime paymentDate, double taxPercentage)
        {
            EmployeeID = employeeID;
            Salary = salary;
            PaymentDate = paymentDate;
            TaxPercentage = taxPercentage;
        }
        public EmployeeSalary() { }

        public override string ToString()
        {
            return $"{EmployeeID} - {Salary} - {PaymentDate.ToShortDateString()} - {TaxPercentage}%";
        }

    }
}
