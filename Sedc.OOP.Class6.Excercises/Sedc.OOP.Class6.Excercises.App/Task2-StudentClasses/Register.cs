using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class6.Excercises.App.Task2_StudentClasses
{
    public class Register
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public void RegisterFunction()
        {
            Console.WriteLine("Please enter your Id, your username, and your password");
            Console.WriteLine("Id:");
            string input = Console.ReadLine();
            int id = int.Parse(input);
            Console.WriteLine("Username:");
            input = Console.ReadLine();
            string username = input;
            Console.WriteLine("Password:");
            input = Console.ReadLine();
            string password = input;

            Id = id;
            Username = username;
            Password = password;
        }
    }
}
