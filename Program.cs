using System;

namespace EmployeeWageOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee wage Calculation ");
            //calculate employee Wage
            Employee Google = new Employee("Google",300,20,70);
            Employee Infosys = new Employee("Infosys", 100, 10, 30);
            Google.ComputeEmpWage();
            Console.WriteLine(Google.Result());
            Infosys.ComputeEmpWage();
            Console.WriteLine(Infosys.Result());
            
            
        }
    }
}
