using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalVidly.Models;
using FinalVidly.ViewModels;

namespace FinalVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = GetMovie();
           
            return View(movie);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovie().SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        private IEnumerable<Movie> GetMovie()
        {
            return new List<Movie>
            {
                new Movie {Id = 1,Name = "Shrek!" },
                new Movie {Id = 2,Name = "Tommy" }
            };

        }
    }
}