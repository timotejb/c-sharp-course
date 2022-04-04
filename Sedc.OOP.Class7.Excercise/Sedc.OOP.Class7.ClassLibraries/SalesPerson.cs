using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class7.ClassLibraries
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue;

        public SalesPerson() //constructor
        {
            Salary = 500;
            Role = Roles.Sales;
        }
        public void AddSuccessRevenue(double n) //meri kolku e succesfull salesmanot
        { 
            SuccessSaleRevenue = n;
        }
        public override double GetSalary() // dava bonus preku getSalary metodata
        {
            if(SuccessSaleRevenue <= 2000)
            {
               return Salary + 500;
            }
            else if (SuccessSaleRevenue >2000 && SuccessSaleRevenue <= 5000)
            {
               return Salary + 1000;
            }
            else 
            {
               return Salary + 1500;
            }
        }
    }
}
