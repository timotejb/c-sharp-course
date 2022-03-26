using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class7.ClassLibraries
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager ()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Role = Roles.Other;

        }
    }
}
