using System;

namespace EmployeeWageOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee wage Calculation ");
            //calculate employee Wage
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("Google", 20, 10, 10);
            empWageBuilder.AddCompanyEmpWage("Infosys", 20, 10, 10);
            empWageBuilder.ComputeEmpWage();

        }
    }
}
