using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        public byte NumInStock { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

    }
}