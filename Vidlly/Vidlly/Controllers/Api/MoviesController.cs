using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidlly.DTo;
using Vidlly.Models;

namespace Vidlly.Controllers.Api
{
    public class MoviesController : ApiController
    {

        private ApplicationDbContext _movieContext;
        public MoviesController()
        {
            _movieContext = new ApplicationDbContext();
        }


        //Get/api/Movies

        public IEnumerable<MovieDto> GetMovies()
        {
            return _movieContext.Movies
                .Include(m=> m.Genre)
                .ToList().Select(Mapper.Map<Movie,MovieDto>);
        }

        //Get/api/Movies/1

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _movieContext.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Movie,MovieDto>(movie));

        }

        //post

        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            _movieContext.Movies.Add(movie);
            _movieContext.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);

        }


        //PUT/api/movies/2

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id,MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }
            var movieInDb = _movieContext.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
            {
                return NotFound();

            }

            Mapper.Map(movieDto, movieInDb);
            _movieContext.SaveChanges();

            return Ok();
        }

        //DELETE/api/movies/2

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = _movieContext.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
            {
                return NotFound();
            }
            _movieContext.Movies.Remove(movieInDb);
            _movieContext.SaveChanges();

            return Ok();
        }

    }
}
