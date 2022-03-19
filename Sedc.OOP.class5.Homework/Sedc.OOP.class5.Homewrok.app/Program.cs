using Sedc.OOP.class5.Homewrok.app.Classes;
using System;
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

            foreach (Wizards wizard in wizards)
            {
                foreach (Creatures creature in creatures)
                {
                    if (creature.Status == false) //if the creature is untamed
                    {
                        if (Battle.Calculate(wizard, creature)) //the duel
                        {
                            Console.WriteLine($"The wizard {wizard.Name} won, and the {creature.Name} has been tamed!");
                            creature.Status = true; //taming the creautre
                        }
                        else
                            Console.WriteLine($"The wizard {wizard.Name} lost his HP, the {creature.Name} won.");
                    }
                }
            }

            foreach (Creatures creature in creatures)
            {
                if (!creature.Status)
                {
                    Console.WriteLine($"{creature.Name} was undefeated");
                }
            }
        }
    }
}
