using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class9.Exercise.App
{
    public class Movie
    {
        public string Title { get; set; }   
        public Genre Genre { get; set; }   
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            if (rating < 1 && rating > 5)
                throw new Exception("Invalid rating");
            Rating = rating;
            TicketPrice = rating*5;
        }
    }
}
