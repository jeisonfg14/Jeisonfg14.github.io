using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaAuthController : ControllerBase
    {
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Authorize(Roles = "User")]
        // GET api/<PruebaAuthController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
