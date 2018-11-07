using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Movie
    {

        public enum Moviegenre
        {
            Action,
            Comedy,
            SciFi,
            Horror
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public Moviegenre Genre { get; set; }

        public Movie(string title, int year, Moviegenre genre)
        {
            Title = title;
            Year = year;
            Genre = genre;
        }
    }
}
