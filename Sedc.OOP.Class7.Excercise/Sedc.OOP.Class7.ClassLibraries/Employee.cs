using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class7.ClassLibraries
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
        protected double Salary { get; set; }
        
        public void PrintInfo ()
        {
            Console.WriteLine($"First name: {FirstName}, last name: {LastName}, salary: {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
    
}
