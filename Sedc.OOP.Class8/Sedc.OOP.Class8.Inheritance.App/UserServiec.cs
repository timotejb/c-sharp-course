using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class8.Inheritance.App
{
    class UserServiec : BaseService
    {
        public void Login()
        {
            ValidateInteger(1);
        }
        public void Register()
        {
            ValidateString("3333");
        }

    }
}
