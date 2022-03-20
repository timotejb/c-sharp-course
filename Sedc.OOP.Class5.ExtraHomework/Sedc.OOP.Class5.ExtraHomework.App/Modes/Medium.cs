using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class5.ExtraHomework.App.Modes
{
    public class Medium
    {
        public static void Game()
        {
            Random random = new Random();
            int n = random.Next(1, 500);
            int guess = 0;
            Console.WriteLine("You choose Medium difficulty: you have 7 tries left to guess my number! (1-500)");
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("Input your guess right here:");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess == n && i == 1)
                {
                    Console.WriteLine("!!! Lucky guess !!!");
                    break;
                }
                else if (guess == n)
                {
                    Console.WriteLine("You got it right!");
                    break;
                }
                else if (n > guess && n - guess < 3)
                {
                    Console.WriteLine($"You're so close, but you need to go higher. Number you inputed was: {guess}!");
                }
                else if (n > guess && n - guess < 10)
                {
                    Console.WriteLine($"Need to go higher. Number you inputed was: {guess}!");
                }
                else if (n > guess)
                {
                    Console.WriteLine("Go higher");
                }
                else if (n < guess && guess - n < 3)
                {
                    Console.WriteLine($"You're so close, but you need to go lower. Number you inputed was: {guess}!");
                }
                else if (n < guess && guess - n < 10)
                {
                    Console.WriteLine($"Need to go lower. Number you inputed was: {guess}!");
                }
                else if (n < guess)
                {
                    Console.WriteLine("Go lower");
                }
                else if (guess != n && i == 7)
                {
                    Console.WriteLine("Sorry, would you like to try again?");
                }
            }
            Console.WriteLine($"The number was {n}");
        }
    }
}
