using Bookly.Models;
using System.Data.Entity;
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
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Books
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageBooks))
                return View("List");
            else
                return View("ReadOnlyList");
        }

        //GET: Books/Details/Id
        public ActionResult Details(int id)
        {
            var book = _context.Books.Include(b => b.Genre).SingleOrDefault(b => b.Id == id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }

        //GET: Books/New
        [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new BookFormViewModel()
            {
                Genres = genres
            };

            return View("BookForm", viewModel);
        }

        //POST: Books/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel(book)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("BookForm", viewModel);
            }

            if (book.Id == 0)
            {
                book.DateAdded = DateTime.Now;
                _context.Books.Add(book);
            }  
            else
            {
                var bookInDb = _context.Books.Single(b => b.Id == book.Id);

                bookInDb.Author = book.Author;
                bookInDb.Name = book.Name;
                bookInDb.GenreId = book.GenreId;
                bookInDb.ReleaseDate = book.ReleaseDate;
                bookInDb.NumInStock = book.NumInStock;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

        //GET: Books/Edit/Id
        [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel(book)
            {
               
                Genres = _context.Genres.ToList()
            };

            return View("BookForm", viewModel);
        }

    }
}