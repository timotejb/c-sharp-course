using System;
using System.Collections.Generic;
using System.Collections;
using Sedc.OOP.Class8.Excerise;
namespace Sedc.OOP.Class8.Excerise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            //phoneBook.Add("Timotej", 077777777);
            //phoneBook.Add("Trajan", 023423434);
            //phoneBook.Add("Stefan", 071234272);

            //Console.WriteLine("Please enter a name:");
            //string input = Console.ReadLine();
            //if (phoneBook.ContainsKey(input))
            //{
            //    Console.WriteLine(phoneBook[input]);
            //}
            //else
            //    Console.WriteLine("ERROR");


            Person person = new Person
            {
                Age = 20,
                FavouriteMusicType = Genre.Trance,
                FName = "Timotej",
                LName = "Bojarovski",
                Id = 5,
                FavouriteSongs = new List<Song>
                {
                    new Song
                    {
                        Title = "dirty 80s"
                    }
                }
            };
            person.GetFavSongs();
        }
    }
}
