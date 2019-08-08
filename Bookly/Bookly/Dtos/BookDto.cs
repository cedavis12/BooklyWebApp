﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookly.Models;
using System.ComponentModel.DataAnnotations;

namespace Bookly.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public byte NumInStock { get; set; }

        [Required]
        public byte GenreId { get; set; }

    }
}