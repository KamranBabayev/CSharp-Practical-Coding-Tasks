using System;
using System.Collections.Generic;
using System.Text;

namespace _05_EmployeeManagement.Models
{
    internal class Manager:Employee
    {
        public Manager(string name,decimal baseSalary):base(name,baseSalary)
        {
            
        }

        public override decimal CalculateSalary()
        {
            return BaseSalary + BaseSalary * 0.2m;
        }

     
    }
}
