using _05_EmployeeManagement.Models;
namespace EmployeeManagement;

internal class Program
{
    static void Main(string[] args)
    {

        //Task 5.
        //Base Employee: Name, BaseSalary propları olsun.
        //Child classes: Manager, Developer.
        //Manager: maash + 20 % bonus.
        //Developer: maash + 10 % bonus.
        //Massivdə 6 işçi saxla, loop ilə maaşları hesabla və ən çox maaş alanı tap.


        Employee[] employees= new Employee[6];
        employees[0] = new Manager("Ali", 1500);
        employees[1] = new Manager("Veli", 2000);
        employees[2] = new Manager("Aysel", 1800);

        employees[3] = new Developer("Murad", 1200);
        employees[4] = new Developer("Leyla", 1600);
        employees[5] = new Developer("Nigar", 2200);

        decimal maxSalary = employees[0].CalculateSalary();
        Employee highestPaidEmployee = employees[0];
        foreach (Employee employee in employees)
        {
            if (employee.CalculateSalary() > maxSalary)
            {
                maxSalary = employee.CalculateSalary();
                highestPaidEmployee = employee;
            }
            
            
        }

        Console.WriteLine($"Name:{highestPaidEmployee.Name}");
        Console.WriteLine($"Salary:{maxSalary}");

    }
}