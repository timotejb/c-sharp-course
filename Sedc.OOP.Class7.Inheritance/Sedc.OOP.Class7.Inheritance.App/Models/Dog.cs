using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class7.Inheritance.App.Models
{
    public class Dog : Animal 
    {
       
        public bool isPlayful { get; set; } 
        
        public Dog()
        {
            Console.WriteLine("A new instance of dog has been created, by  the parent constructor");
        }
        public Dog( string name, string type)
            : base(name, type, "Doggy")
        {
            Console.WriteLine("A new instance of dog has been created, by  the parent constructor with parameters");
            isPlayful = true;
        }
    }
}
