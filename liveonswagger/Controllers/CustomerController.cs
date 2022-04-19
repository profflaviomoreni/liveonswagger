using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liveonswagger.Model;
using Microsoft.AspNetCore.Mvc;

namespace liveonswagger.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult<IList<CustomerGet>> Get()
        {
            IList<CustomerGet> customers = new List<CustomerGet>();
            customers.Add(new CustomerGet()
            {
                FirstName = "José",
                LastName = "Silva Jr",
                Email = "jose@domain.com",
                Active = true,
                IdCustomer = 1,
                CreatedAt = DateTime.Now
            });

            customers.Add(new CustomerGet()
            {
                FirstName = "Maria",
                LastName = "Silva Filha",
                Email = "maria@domain.com",
                Active = true,
                IdCustomer = 2,
                CreatedAt = DateTime.Now
            });


            return Ok(customers);
        }


        [HttpGet("{id}" , Name = "GET")]
        public ActionResult<CustomerGet> Get(int id)
        {
            var customer = new CustomerGet()
            {
                FirstName = "Maria",
                LastName = "Silva Filha",
                Email = "maria@domain.com",
                Active = true,
                IdCustomer = 2,
                CreatedAt = DateTime.Now
            };


            return Ok(customer) ;
        }


        [HttpPost]
        public ActionResult Post([FromBody] CustomerPost customer)
        {
            var customerGet = new CustomerGet()
            {
                FirstName = "Maria",
                LastName = "Silva Filha",
                Email = "maria@domain.com",
                Active = true,
                IdCustomer = 2,
                CreatedAt = DateTime.Now
            };

            return CreatedAtRoute("Get",
                new { id = customerGet.IdCustomer },
                value: customerGet );
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerPut customer)
        {
            if (id == 3)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if ( id == 3)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
