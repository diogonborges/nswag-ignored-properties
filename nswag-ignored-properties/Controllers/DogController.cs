using Microsoft.AspNetCore.Mvc;

namespace nswag_ignored_properties.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Dog> Get()
        {
            return Ok();
        }
    }
}
