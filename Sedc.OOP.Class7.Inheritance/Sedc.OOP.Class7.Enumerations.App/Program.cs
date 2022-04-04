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

            //parsiranje integer vo enum
            bool isValid = Enum.TryParse(typeof(Roles), "2", out object role); //na "role" mu ja zadavame vrednosta "2"(Admin
                                                                               //) od "Roles"
            Console.WriteLine(role);
            Console.WriteLine(admin);
        }
    }
}
