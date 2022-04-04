using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class8.Inheritance.App
{
    public class Student : Person
    {
        public int Grade { get; set; }
        public Student() => Id = 10;
    }
}
