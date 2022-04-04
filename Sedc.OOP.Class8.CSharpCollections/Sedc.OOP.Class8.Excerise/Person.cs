using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class8.Excerise
{
    public class Person
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person()
        {
            FavouriteSongs = new List<Song>();
        }
        public void GetFavSongs()
        {
            foreach (Song song in FavouriteSongs) {
                Console.WriteLine((song.Title));
            }
        }
    }
       
}
