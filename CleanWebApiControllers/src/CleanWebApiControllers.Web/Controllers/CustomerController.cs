using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CleanWebApiControllers.Web.AppLayer;
using CleanWebApiControllers.Web.Models;

namespace CleanWebApiControllers.Web.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private readonly ICustomersApplicationService _customersService;

        public CustomersController(ICustomersApplicationService customersService)
        {
            _customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));
        }

        [HttpPost, Route(""), ResponseType(typeof(int))]
        public IHttpActionResult Post(ClientCustomer customer)
        {
            var newCustomer = _customersService.Create(customer);
            return CreatedAtRoute("GetById", newCustomer, newCustomer.Id);
        }

        [HttpGet, Route(""), ResponseType(typeof(List<string>))]
        public IHttpActionResult GetAll()
        {
            var customers = _customersService.GetAll();
            return Ok(customers);
        }

        [HttpGet, Route("{id}", Name = "GetById"), ResponseType(typeof(Customer))]
        public IHttpActionResult Get(string id)
        {
            var matchingCustomer = _customersService.Get(id);
            if (matchingCustomer == null)
                return NotFound();

            return Ok(matchingCustomer);
        }

        [HttpPut, Route("", Name = "Update")]
        public IHttpActionResult Update(Customer customer)
        {
            _customersService.Update(customer);
            return Ok();
        }
    }
}
