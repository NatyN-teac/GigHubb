using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidlly.Models;

namespace Vidlly.ViewModels
{
    public class MovieModelViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]

        [Required]
        public DateTime? ReleaseDate { get; set; }

  

        [Display(Name = "Number In Stock")]
        [Required]
        [Range(1, 20, ErrorMessage = "number in stock must be between 1 and 20 ")]
        public int? NumberInStock { get; set; }

        

        [Display(Name = "Genre")]
        [Required]
        public int GenreId { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }

        }

        public MovieModelViewModel()
        {
            Id = 0;
        }

        public MovieModelViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;

        }

    }
}