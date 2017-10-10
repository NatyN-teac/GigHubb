using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlly.Models;
using System.Data.Entity;
using Vidlly.ViewModels;
using System.Data.Entity.Infrastructure;

namespace Vidlly.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext _MovieContext;

        public MoviesController()
        {
            _MovieContext = new ApplicationDbContext();
        }





        // GET: Movie
        public ActionResult Index()
        {

            // var movie = _MovieContext.Movies.Include(m => m.Genre).ToList() ;
            if (User.IsInRole("CanManageMovies"))
                return View("List");
            return View("ReadOnlyList");

            
        }

        public ActionResult Details(int id)
        {
            var movies = _MovieContext.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if(movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        } 
       
        
        public ActionResult NewMovie()
        {
            var genre = _MovieContext.Genres.ToList();
            var viewmodel = new MovieModelViewModel
            {
                Genre = genre
            };
            return View("NewMovie",viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieModelViewModel(movie)
                {
                   
                    Genre = _MovieContext.Genres.ToList()
                };
                return View("NewMovie", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
 
                _MovieContext.Movies.Add(movie);
            }
            else
            {
                var MovieInDb = _MovieContext.Movies.Single(m => m.Id == movie.Id);
                MovieInDb.Name = movie.Name;
                MovieInDb.ReleaseDate = movie.ReleaseDate;
                MovieInDb.NumberInStock = movie.NumberInStock;
                MovieInDb.GenreId = movie.GenreId;
            }

           
                _MovieContext.SaveChanges();               
       

            return RedirectToAction("Index", "Movies");

        }


        public ActionResult Edit(int id)
        {
            var movie = _MovieContext.Movies.Single(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var ViewModel = new MovieModelViewModel(movie)
            {
               
               
                Genre = _MovieContext.Genres.ToList()

            };
            return View("NewMovie", ViewModel);
        }

    }
}