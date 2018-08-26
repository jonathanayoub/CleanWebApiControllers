using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using DirtyWebApiControllers.Data;
using DirtyWebApiControllers.Models;

namespace DirtyWebApiControllers.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        [HttpPost, Route(""), ResponseType(typeof(int))]
        public IHttpActionResult Post(Customer customer)
        {
            using (var db = new CustomerDbContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }

            return CreatedAtRoute("GetById", customer, customer.Id);
        }

        [HttpGet, Route(""), ResponseType(typeof(List<string>))]
        public IHttpActionResult Get()
        {
            using (var db = new CustomerDbContext())
            {
                return Ok(db.Customers.ToList());
            }
        }

        [HttpGet, Route("{id:int}", Name = "GetById"), ResponseType(typeof(int))]
        public IHttpActionResult Get(int id)
        {
            if (id <= 0)
                return NotFound();

            using (var db = new CustomerDbContext())
            {
                var matchingCustomer = db.Customers.SingleOrDefault(c => c.Id == id);
                if (matchingCustomer == null)
                    return NotFound();
                return Ok(matchingCustomer);
            }
        }

        [HttpPut, Route("", Name = "Update")]
        public IHttpActionResult Update(Customer customer)
        {
            using (var db = new CustomerDbContext())
            {
                var existingCustomer = db.Customers.Single(c => c.Id == customer.Id);
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.FavoriteIceCream = customer.FavoriteIceCream;
                db.SaveChanges();
            }

            return Ok();
        }
    }
}
