using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _05_EmployeeManagement.Models
{
    internal class Developer:Employee
    {

        public Developer (string name, decimal baseSalary):base(name, baseSalary)
        {
            
        }

        public override decimal CalculateSalary()
        {
            return BaseSalary + BaseSalary * 0.1m;
        }
    }
}
