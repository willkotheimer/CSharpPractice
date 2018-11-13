using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoutesMVC.Models;


namespace RoutesMVC.Services
{
    public class EntertainmentServices : IEntertainmentService
    {
        public IEnumerable<Games> GetGames()
        {
            return new List<Games>()
            {
                new Games() { Title="The Witcher", Genre="RPG"},
                new Games() { Title="Need for Speed", Genre="Racing"},
                new Games() {Title="Crysis", Genre="FPS"}
            };
        }
        public IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>()
            {
            new Movies() { Title="Star Wars", Ranking=1, Genre="SciFi" },
            new Movies() {Title="Inception", Ranking=2, Genre="Scifi"},
            new Movies() {Title="Ghost in a shell", Ranking=3, Genre="SciFi"}
            };
        }
    }
}
