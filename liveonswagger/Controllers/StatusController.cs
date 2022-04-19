using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace liveonswagger.Controllers
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ativo", "inativo" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "ativo";
        }

        
    }
}
