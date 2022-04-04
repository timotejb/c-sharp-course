using System;
using System.Collections.Generic;

namespace Sedc.OOP.Class9.Exercise.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>(){
                new Movie("Movie", Genre.Western, 2),
                new Movie("Movie1", Genre.Western, 5),
                new Movie("Movie2", Genre.Action, 4),
                new Movie("Movie3", Genre.Western, 3),
                new Movie("Movie4", Genre.Comedy, 1),
                new Movie("Movie5", Genre.SciFi, 1)
            };
            
        }
    }
}
