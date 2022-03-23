using System;
using Sedc.OOP.Class7.Enumerations.App.Enums;
using Sedc.OOP.Class7.Enumerations.App.Models;
namespace Sedc.OOP.Class7.Enumerations.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator("Bob");
            admin.Role = Roles.SuperGuest;
            Console.WriteLine(admin);
        }
    }
}
