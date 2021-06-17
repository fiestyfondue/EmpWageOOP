using System;

namespace EmployeeWageOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee wage Calculation ");
            //calculate employee Wage
            Employee employee = new Employee();
            employee.ComputeEmpWage("Google", 24, 20, 50);
            employee.ComputeEmpWage("Infosys", 35, 25, 100);
        }
    }
}
