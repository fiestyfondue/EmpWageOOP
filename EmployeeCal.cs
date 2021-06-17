using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOP
{
    public class Employee
    {
        private string company;
        private int Wage_Per_Hr;
        private int numWorkingDays;
        private int MaxHrsPerMonth;
        private int totalWage;

        public Employee(string company,int Wage_Per_Hr,int numWorkingDays,int MaxHrsPerMonth)
        {
            this.company = company;
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.numWorkingDays = numWorkingDays;
            this.MaxHrsPerMonth = MaxHrsPerMonth;
        }
        public void ComputeEmpWage()
        {
            //constants
            const int IS_FULL_TIME = 8;
            const int IS_PART_TIME = 4;
            



            //variables
            int dailyWage = 0;
            int day ;
            int isPresent;
            int totalHours = 0;

            //random number generation
            Random rand = new Random();
            for (day = 1; day <= this.numWorkingDays; day++)
            {
                isPresent = rand.Next(0, 3);

                switch (isPresent)
                {
                    case 1:
                        {
                            Console.WriteLine("The employer is full time");
                            dailyWage = this.Wage_Per_Hr * IS_FULL_TIME;
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("The employer is Part time");
                            dailyWage = this.Wage_Per_Hr * IS_PART_TIME;
                            Console.WriteLine($"Daily wage is {dailyWage}");
                            break;
                        }
                    default:
                        {
                            dailyWage = isPresent;
                            break;
                        }
                }
                //checking total number of hours
                totalHours += dailyWage / 20;
                totalWage += dailyWage;
                if (totalHours >= this.MaxHrsPerMonth)
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"Company Name :{this.company}");
            Console.WriteLine($"No. of hours worked :{totalHours}");
            Console.WriteLine($"Wage Per hour :{this.Wage_Per_Hr}");
            Console.WriteLine($"Monthly wage :{this.totalWage}");

            
            }
            public string Result()
            {
            return "Total Employee wage for Comapny : " + this.company + " is " + this.totalWage;
            }


    }

}


