using System;
using Sedc.OOP.Class7.Services;
namespace Sedc.OOP.Class7.ClassLibraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeservice = new EmployeeService();
            employeeservice.CreateObjectAndWriteInConsole();
        }
    }
}
