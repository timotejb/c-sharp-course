using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class9.Exercise.App
{
    public class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching movie {movie}");
        }
    }
}
