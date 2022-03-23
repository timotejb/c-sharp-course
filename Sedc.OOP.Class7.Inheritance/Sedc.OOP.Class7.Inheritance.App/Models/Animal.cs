using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class7.Inheritance.App.Models
{
    public class Animal 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Race { get; set; }

        public Animal()
        {
            Console.WriteLine("A new instace of an animal has been created, this is the Animal constructor");
        }        
        public Animal( string name, string type , string race)
        {
            Name = name;
            Type = type;    
            Race = race;
            Console.WriteLine("A new instance of Animal has been created, by  the Animal constructor");
        }
    }
}
