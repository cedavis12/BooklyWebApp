using Bookly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bookly.Dtos;

namespace Bookly.API
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }


        //POST api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto newRental)
        {
        
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerID);

            var books = _context.Books.Where(b => newRental.BookIds.Contains(b.Id)).ToList();


            foreach(var book in books)
            {
                if (book.NumAvailable == 0)
                    return BadRequest("Book is not available");

                book.NumAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Book = book,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

    }
}
