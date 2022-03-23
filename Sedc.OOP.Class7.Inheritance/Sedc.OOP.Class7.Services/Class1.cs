using System;
using Sedc.OOP.Class7.Services;
using Sedc.OOP.Class7.Models;
using Sedc.OOP.Class7.Models.Enums;
namespace Sedc.OOP.Class7.Services
{
    public class EmployeeService
    {
        public void CreateObjectAndWriteInConsole()
        {
            Employee employee = new Employee() { Id = 1, Name = "Bob", Role = Roles.Admin };
        }
    }
}
