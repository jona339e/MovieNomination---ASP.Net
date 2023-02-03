using Microsoft.AspNetCore.Mvc;
using MovieNomination___ASP.Net.Models;
using MovieNomination___ASP.Net.Services;

namespace MovieNomination___ASP.Net.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            List<MoviesModel> movieList = new List<MoviesModel>();
            GETLIST gl = new();
            movieList = gl.GetData();

            return View(movieList);
        }


    }
}
