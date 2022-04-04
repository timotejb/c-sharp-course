using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class7.Inheritance.App.Models
{
    public class Cat : Animal
    {
        
        public bool IsLazy { get; set; }

        public Cat()
        {
            Console.WriteLine("A new instace of Cat has been creted by the parent constructor.");
        }
        public Cat(string name, string type, string race, bool isLazy)
        : base(name, type, race)
        {
            IsLazy = isLazy;
        }
        public void CatEat()
        
        {
            Console.WriteLine("Dog eats food!");
            base.Eat();    
        }
        public override void Eat()
        {
            base.Eat();
            if (IsLazy)
            {
                Console.WriteLine("We need to feed the cat with a spoon");
            }
            else
            {
                Console.WriteLine("The cat is eating");
            }
        }
    }
}
