using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class6.Excercises.App.Task2_StudentClasses
{
    public class Student
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        Login login = new Login();
       
    }
}
