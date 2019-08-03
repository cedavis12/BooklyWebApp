using Bookly.Models;
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
            return View();
        }

        //GET: Books/Random
        public ActionResult Random()
        {
            var movie = new Book() { Name = "Frankenstein" };

            return View(movie);
        }
    }
}