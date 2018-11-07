using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Star Wars", 1977, Movie.Moviegenre.SciFi);
            printMovieGenre(movie);
            Console.ReadKey();
        }
        private static void printMovieGenre(Movie movie)
        {

            switch (movie.Genre)
            {

                case Movie.Moviegenre.Action:
                    Console.WriteLine("Action movie");
                    break;
                case Movie.Moviegenre.Comedy:
                    Console.WriteLine("Comedy movie");
                    break;
                case Movie.Moviegenre.SciFi:
                    Console.WriteLine("Science Fiction Movie");
                    break;
                case Movie.Moviegenre.Horror:
                    Console.WriteLine("Horror Movie");
                    break;
                default:
                    Console.WriteLine("Invalid Movie Case");
                    break;
            

        }
        }
    }

}