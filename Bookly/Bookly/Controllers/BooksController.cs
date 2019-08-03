using Bookly.Models;
using Bookly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookly.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            var books = GetBooks();

            return View(books);
        }


        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Name = "Quack Quack Moo", Id = 1},
                new Book {Name = "Quack Quack Peep", Id = 2},
                new Book {Name = "Quack Quack Duck", Id = 3}
            };
        }

     
    }
}