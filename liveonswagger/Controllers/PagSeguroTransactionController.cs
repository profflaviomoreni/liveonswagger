using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using liveonswagger.Model;
using Microsoft.AspNetCore.Mvc;

namespace liveonswagger.Controllers
{
    [Route("api/[controller]")]
    public class PagSeguroTransactionController : Controller
    {

        [HttpGet("{id}/detail")]
        public ActionResult<PagSeguroTransactionGetDetail> Get(int id)
        {
            var retorno = new PagSeguroTransactionGetDetail()
            {
                Customer = CreateCustomer(),
                Code = "9898-099808-9797987",
                DateOfCreation = DateTime.Now,
                DateOfLastEvent = DateTime.Now,
                Status = "Created",
                NetAmount = 1000,
                Email = "maria@mail.com",
                Name = "Maria",
                Active = true
            };

            return Ok(retorno);
        }


        [HttpGet("{customerId}/listByCustomer")]
        public ActionResult<PagSeguroTransactionGetDetail> GetByCustomerId(int customerId)
        {
            var retorno = new PagSeguroTransactionGetDetail()
            {
                Customer = CreateCustomer(),
                Code = "9898-099808-9797987",
                DateOfCreation = DateTime.Now,
                DateOfLastEvent = DateTime.Now,
                Status = "Created",
                NetAmount = 1000,
                Email = "maria@mail.com",
                Name = "Maria",
                Active = true
            };

            return Ok(retorno);
        }



        [HttpGet("{id}/status")]
        public ActionResult<string> GetStatus(int id)
        {
            return Ok("Processing");
        }



        [HttpPost]
        public ActionResult<PagSeguroTransactionGetDetail> Post([FromBody] PagSeguroTransactionPost pagSeguroTransaction)
        {
            var retorno = new PagSeguroTransactionGetDetail()
            {
                Customer = CreateCustomer(),
                Code = "9898-099808-9797987",
                DateOfCreation = DateTime.Now,
                DateOfLastEvent = DateTime.Now,
                Status = "Created",
                NetAmount = 1000,
                Email = "maria@mail.com",
                Name = "Maria",
                Active = true
            };

            return Ok(retorno);
        }


        // DELETE api/values/5
        [HttpDelete("{id}/cancel")]
        public ActionResult Delete(int id)
        {
            return NoContent();
        }


        private CustomerGet CreateCustomer()
        {
            return new CustomerGet()
            {
                FirstName = "Maria",
                LastName = "Silva Filha",
                Email = "maria@domain.com",
                Active = true,
                IdCustomer = 2,
                CreatedAt = DateTime.Now
            };
        }

    }
}
