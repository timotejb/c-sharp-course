using System;
using Sedc.OOP.Class7.Inheritance.App.Models;
namespace Sedc.OOP.Class7.Inheritance.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Animal animal = new Animal(){ Name =  "Dambo", Id =  2, Type = "Elephant", Race = "WhiteOnes" };
            animal.Eat();
            Dog dog = new Dog() { Name = "Sparky", Id = 1, Type = "Dog",Race = "PitBUll",isPlayful = true };
            dog.Eat();
            Cat cat = new Cat() { Name = "Garfield", Id = 1, Race = "Cat", Type = "Yellow cat", IsLazy = true };
            cat.Eat();
            //Dog dog2 = new Dog("Sparky2", "Dog");
            //Cat cat2 = new Cat("Cat2", "Yellow", "Norace", false);
        }
    }
}
