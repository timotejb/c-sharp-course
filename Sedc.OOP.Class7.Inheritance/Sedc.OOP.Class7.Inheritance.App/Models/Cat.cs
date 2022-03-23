﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class7.Inheritance.App.Models
{
    public class Cat : Animal
    {
        
        public bool IsPlayful { get; set; }

        public Cat()
        {
            Console.WriteLine("A new instace of Cat has been creted by the parent constructor.");
        }
        public Cat(string name, string type, string race, bool isPlayful)
        : base(name, type, race)
        {
            IsPlayful = isPlayful;
        }
    }
}
