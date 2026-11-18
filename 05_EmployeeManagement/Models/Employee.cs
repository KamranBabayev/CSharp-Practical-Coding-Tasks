using System;
using System.Collections.Generic;
using System.Text;

namespace _05_EmployeeManagement.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name,decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }


        public virtual decimal CalculateSalary()
        {
            return BaseSalary;

        }
    }
}
