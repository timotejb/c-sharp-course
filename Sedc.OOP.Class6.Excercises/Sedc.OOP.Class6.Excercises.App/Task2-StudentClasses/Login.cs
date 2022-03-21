using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class6.Excercises.App.Task2_StudentClasses
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public void LoginFunction(string username, string password)
        {
            Console.WriteLine("Please enter your username and password:");
            Console.WriteLine("Username:");
            string input = Console.ReadLine();
            username = input;
            Console.WriteLine("Password:");
            input = Console.ReadLine();
            password = input;
            Username = username;
            Password = password;
        }
    }
}
