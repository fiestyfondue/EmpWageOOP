﻿using System;

namespace EmployeeWageOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation ");
            //check employee attendence
            Employee employee = new Employee();
            employee.AttendenceCheck();
            Console.ReadLine();
        }
    }
}
