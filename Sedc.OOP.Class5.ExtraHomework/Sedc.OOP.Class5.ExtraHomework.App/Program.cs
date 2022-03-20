using System;
using Sedc.OOP.Class5.ExtraHomework.App.Modes;
namespace Sedc.OOP.Class5.ExtraHomework.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enert the game mode you want: Easy, Medium or Hard");
            string difficulty = Console.ReadLine();
            difficulty = difficulty.ToLower();
            if (difficulty == "easy")
            {
                Easy.Game();
            }
            else if (difficulty == "medium")
            {
                Medium.Game();
            }
            else if (difficulty == "hard")
            {
                Hard.Game();
            }
        }
    }
}
