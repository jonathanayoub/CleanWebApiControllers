using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using DirtyWebApiControllers.Models;

namespace DirtyWebApiControllers.Controllers
{
    /// <summary>
    /// Represents test controller that should be removed.
    /// </summary>
    [RoutePrefix("api")]
    public class CustomersController : ApiController
    {
        [HttpPost, Route(""), ResponseType(typeof(int))]
        public IHttpActionResult Post(string value)
        {
            var id = new Random().Next();

            return CreatedAtRoute("GetById", new { id }, id);
        }

        [HttpGet, Route(""), ResponseType(typeof(List<string>))]
        public IHttpActionResult Get()
        {
            return Ok(new List<string> { "Test 1", "Test 2" });
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
