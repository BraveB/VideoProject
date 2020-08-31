using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using VideoProject.App_Data;
using VideoProject.Dtos;
using VideoProject.Models;

namespace VideoProject.Controllers.Api
{
    public class RentalController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(RentalDto rentalDto)
        {
            var customer = _context.Customer.Single(c => c.Id == rentalDto.CustomerId);

            var movies = _context.Movie.Where(
                m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            foreach(var movie in movies)
            {
                if (movie.Available == 0)
                    return BadRequest("Movie is not available.");

                movie.Available--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rental.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}