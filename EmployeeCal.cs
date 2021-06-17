using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOP
{
    class Employee
    {
        public void AttendenceCheck()
        {
            //constants
            const int WAGE_PER_HR = 20;
            const int IS_FULL_TIME = 8;
            const int IS_PART_TIME = 4;
            const int WORKING_DAYS = 20;
            //variables
            int dailyWage = 0;
            int day = 0;
            int isPresent;
            int totalWage = 0;
            int totalHours = 0;

            //random number generation
            Random rand = new Random();
            for (day = 1; day <= WORKING_DAYS; day++)
            {
                isPresent = rand.Next(0, 3);

                switch (isPresent)
                {
                    case 1:
                        {
                            dailyWage = WAGE_PER_HR * IS_FULL_TIME;
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                    case 2:
                        {
                            dailyWage = WAGE_PER_HR * IS_PART_TIME;
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
                if (totalHours >= 100)
                {
                    break;
                }
                Console.WriteLine($"Montly wage is {totalWage} and working hours is {totalHours}");
            }

        }

    }
}

