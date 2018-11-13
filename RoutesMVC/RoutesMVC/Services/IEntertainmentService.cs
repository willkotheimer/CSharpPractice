using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoutesMVC.Models;

namespace RoutesMVC.Services
{
    public interface IEntertainmentService
    {
        IEnumerable<Games> GetGames();
        IEnumerable<Movies> GetMovies();
    }
}
