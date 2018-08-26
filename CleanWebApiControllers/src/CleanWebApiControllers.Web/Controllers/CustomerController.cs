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
        public IHttpActionResult Post(Customer customer)
        {
            return CreatedAtRoute("GetById", new {}, 1);
        }

        [HttpGet, Route(""), ResponseType(typeof(List<string>))]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        [HttpGet, Route("{id:int}", Name = "GetById"), ResponseType(typeof(int))]
        public IHttpActionResult Get(int id)
        {
            if (id <= 0)
                return NotFound();

            return Ok();
        }

        [HttpPut, Route("", Name = "Update")]
        public IHttpActionResult Update(Customer customer)
        {
            return Ok();
        }
    }
}
