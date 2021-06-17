﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOP
{
    class CompanyWage
    {
        //properties 
        public string company;
        public int wagePerHour;
        public int numWorkingDays;
        public int maxHoursPerMonth;
        public int totalWage;


        public CompanyWage(string company, int wagePerHour, int numWorkingDays, int maxHoursPerMonth)
        {
            //Constructor
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.numWorkingDays = numWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalWage = totalEmpWage;
        }

        public string Result()
        {
            return "Total Employee wage for Comapny : " + this.company + " is " + this.totalWage;
        }
    }
}
