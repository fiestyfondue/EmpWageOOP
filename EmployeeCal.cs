using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOP
{
    class Employee
    {
        public void ComputeEmpWage(string company, int wagePerHour, int numWorkingDays, int maxHoursPerMonth)
        {
            //constants
            
            const int IS_FULL_TIME = 8;
            const int IS_PART_TIME = 4;
            

            //variables
            int dailyWage = 0;
            int day ;
            int isPresent;
            int totalWage = 0;
            int totalHours = 0;

            //random number generation
            Random rand = new Random();
            for (day = 1; day <= numWorkingDays; day++)
            {
                isPresent = rand.Next(0, 3);

                switch (isPresent)
                {
                    case 1:
                        {
                            Console.WriteLine("The employer is full time");
                            dailyWage = wagePerHour * IS_FULL_TIME;
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("The employer is Part time");
                            dailyWage = wagePerHour * IS_PART_TIME;
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                }
                //checking total number of hours
                totalHours += dailyWage / 20;
                totalWage += dailyWage;
                if (totalHours >= maxHoursPerMonth)
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine($"Company Name :{company}");
                Console.WriteLine($"No. of hours worked :{totalHours}");
                Console.WriteLine($"Wage Per hour :{wagePerHour}");
                Console.WriteLine($"Monthly wage :{totalWage}");
                Console.WriteLine();
            }

        }

    }
}

