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
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult Customers(string query = null)
        {
            var customerQuery = _context.Customer
                .Include(c => c.MembershipType);

            if (!string.IsNullOrWhiteSpace(query))
                customerQuery = customerQuery.Where(c => c.Name.Contains(query));

            var customersDtos = customerQuery
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customersDtos);
        }

        [HttpGet]
        public IHttpActionResult Customers(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);

            if (null == customer)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customer.Add(customer);
            _context.SaveChanges();

            customerDto.Id = Convert.ToByte(customer.Id);

            return Created(new Uri(Request.RequestUri + "/" + customerDto.Id), customerDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customerInDb = _context.Customer.SingleOrDefault(c => c.Id == id);

            if (null == customerInDb)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customer.SingleOrDefault(c => c.Id == id);

            if (null == customerInDb)

                return NotFound();

            _context.Customer.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}