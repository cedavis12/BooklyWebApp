using Bookly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.ViewModels
{
    public class BookFormViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public string Title
        {
            get
            {
                if (Book != null && Book.Id != 0)
                    return "Edit Book";

                return "New Book";
            }
        }
    }
}