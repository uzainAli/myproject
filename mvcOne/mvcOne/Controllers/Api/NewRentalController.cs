using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mvcOne.Dtos;
using mvcOne.Models;
namespace mvcOne.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        ApplicationDbContext _context=new ApplicationDbContext();

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {

            var customer = _context.Customer.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movie.Where(m => newRental.MovieIds.Contains(m.Id));
            
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)

                return BadRequest("Movie is not avalable");


                movie.NumberAvailable--;
                var rental = new Rental() 
                {
                    Customer=customer,
                    Movie=movie,
                    DateRented=DateTime.Now
                };
                _context.Rental.Add(rental);
            }
            _context.SaveChanges();
            return Ok();
            
            
        }   
    }
}
