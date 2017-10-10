using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using vudly.Models;
using vudly.ViewModels;

namespace vudly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _MovieContext;

        public MoviesController()
        {
            _MovieContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _MovieContext.Dispose();
        }

        // GET: Movies/index

        public ActionResult Index()
        {
            var movie = _MovieContext.Movie.Include(m =>m.GenreId).ToList() ;
            return View(movie);
        }

       
        public ActionResult Details(int id)
        {
            var movies = _MovieContext.Movie.Include(m => m.GenreId).SingleOrDefault(m => m.Id == id);

            if(movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
              
        }

        public ActionResult NewMovie()
        {
            var Genres = _MovieContext.Genre.ToList();

            var movieViewModel = new NewMoviesViewModel
            {
                Genre = Genres
            };

            return View(movieViewModel);
        }
        
        [HttpPost]
        public ActionResult Save( Movie movie)
        {
            if(movie.Id == 0)
            {
                _MovieContext.Movie.Add(movie);
            }
            else
            {
                var MovieInDb = _MovieContext.Movie.Single(m => m.Id == movie.Id);
                MovieInDb.Name = movie.Name;
                MovieInDb.ReleasedDate = movie.ReleasedDate;
                MovieInDb.GenreId = movie.GenreId;
                MovieInDb.NumberInStock = movie.NumberInStock;

            }
           
                _MovieContext.SaveChanges();
          
            
            return RedirectToAction("Index","Movies");
        }

        public ActionResult EditMovie( int id)
        {
            var movie = _MovieContext.Movie.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var MovieViewModel = new NewMoviesViewModel
            {
                Movie = movie,
                Genre = _MovieContext.Genre.ToList()

            };

            return View("NewMovie",MovieViewModel);
        }
        
       
    }
}