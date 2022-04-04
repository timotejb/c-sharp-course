using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class8.Inheritance.App
{
    public class BaseService
    {
        //validacii se koristat vo base service
        protected bool ValidateInteger(int num)
        {
            return true;
        }

        protected bool ValidateString(string str)
        {
            return true;
        }

    }
}
