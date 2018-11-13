using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutesMVC.Models;
using RoutesMVC.Services;



namespace RoutesMVC.Controllers
{
    [Route("mypages")]
    public class PagesController : Controller
    {
        private IEntertainmentService _service;

        //Service will be injected:
         public PagesController(IEntertainmentService service)
        {
            _service = service;
        }



        [Route("mygames", Name="MyGames")]
        public IActionResult Games()
        {
            ViewData["games"] = _service.GetGames();

            //ViewData["games"] = new List<Games>()
            //{
            //    new Games() { Title="The Witcher", Genre="RPG"},
            //    new Games() { Title="Need for Speed", Genre="Racing"},
            //    new Games() {Title="Crysis", Genre="FPS"}
            //};
            return View();
        }
        [Route("mymovies",Name="MyMovies")]
        public IActionResult Movies()
        {
            var movies = _service.GetMovies();
            //var movies = new List<Movies>()
            //{
            //new Movies() { Title="Star Wars", Ranking=1, Genre="SciFi" },
            //new Movies() {Title="Inception", Ranking=2, Genre="Scifi"},
            //new Movies() {Title="Ghost in a shell", Ranking=3, Genre="SciFi"}
            //};
            return View(movies);
            
            
        }
    }
}