using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using System.Web;

namespace vudly.Models
{
    public class Movie
    {


        public int Id { get; set; }
        public string Name { get; set; }


        [Required]
       
        public DateTime DateAdded { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        [Display(Name = "Released Date")]        
        public DateTime ReleasedDate { get; set; }

        [Required]
        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }
        [Display(Name = "Genre")]

        public Genre GenreId { get; set; }




    }
}