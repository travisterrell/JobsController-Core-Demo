using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UE2.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class APIController : Controller
    {

        [HttpGet("test", Name = "test")]
        public IActionResult Get(int? id)
        {
            return id != null
                ? new ObjectResult($"The API is functioning. Your id is {id}") 
                : new ObjectResult("The API is functioning. You did not supply an id.");
        }

        [HttpPost("test", Name = "test")]
        public IActionResult Post(int? id)
        {
            return id != null
                ? new ObjectResult($"The API is functioning. Your id is {id}")
                : new ObjectResult("The API is functioning. You did not supply an id.");
        }
    }
}
