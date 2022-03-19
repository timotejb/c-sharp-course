using System;
using Sedc.OOP.class5.Homewrok.app.Classes;
namespace Sedc.OOP.class5.Homewrok.app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Each wizard should be able to duel a creature if the creature has not yet been tamed.
            //If the wizard’s power level is greater than the creature’s power level,
            //they essentially win the duel and that creature is at that moment tamed.
            Wizards[] wizards =
            {
                new Wizards
                {
                    Name = "Timotej",
                    PowerLevel = 20,
                    //doaHogwarts = new DateTime(2001,23,06),
                    graduationStatus = false
                },
                new Wizards
                {
                    Name = "Sonja",
                    PowerLevel = 40,
                    //doaHogwarts = new DateTime(1967,18,07),    
                    graduationStatus = true
                }
            };
            Creatures[] creatures =
            {
                new Creatures
                {
                    Name = "Panko",
                    Age = 100,
                    Status = false, //untamed
                    PowerLevel = 23
                },
                new Creatures
                {
                    Name = "Fengo",
                    Age = 23,
                    Status = false, //untamed
                    PowerLevel = 120
                }
            };

            //Battle begins
            if (creatures[1].Status == false) //if the creature is untamed
            {
                if (Battle.Calculate(wizards[0].PowerLevel, creatures[1].PowerLevel)) //the duel
                {
                    Console.WriteLine($"The wizard {wizards[0].Name} won, and the {creatures[1].Name} has been tamed!");
                    creatures[1].Status = true; //taming the creautre
                }
                else
                    Console.WriteLine($"The wizard {wizards[0].Name} lost his HP, the {creatures[1].Name} won.");
            }


        }
    }
}
