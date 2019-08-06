using Bookly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bookly.ViewModels
{
    public class BookFormViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; } 

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public byte? NumInStock { get; set; } = 0;

        [Required]
        public byte? GenreId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Book" : "New Book";

            }
        }

        public BookFormViewModel()
        {
            Id = 0;
            NumInStock = 0;
            ReleaseDate = new DateTime(0001, 01, 01);
        }

        public BookFormViewModel(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            Author = book.Author;
            ReleaseDate = book.ReleaseDate;
            NumInStock = book.NumInStock;
            GenreId = book.GenreId;
        }
    }
}