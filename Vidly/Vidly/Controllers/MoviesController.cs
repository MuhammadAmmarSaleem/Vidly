using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //use Route Attribute for 'Attribute Route'. To apply constraint we use regex.
        /*
         *  Different Constraint can be used like:
         *  min, max, minlength, maxlength, int, float, guid
         *  
         *  More Info: ASP.NET MVC Attribute Route Constraints
         */
         
        [Route("movies/released/{year: regex(\\d{4})}/{month: regex(\\d{2}): range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult GetAll()
        {
            List<Movie> movies = GetAllMovies();
            return View("~/Views/Movies/MovieList.cshtml", movies);
        }

        public ActionResult Details(long id)
        {
            List<Movie> movies = GetAllMovies();
            Movie movie = movies.Find(x => x.Id == id);
            return View("~/Views/Movies/MovieDetail.cshtml", movie);

        }

        private List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie{Id = 1, Name = "Sherek"},
                new Movie{Id = 1, Name = "Home Alone."}
            };
            return movies;
        }
        
    }
}