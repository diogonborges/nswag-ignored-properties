using Microsoft.AspNetCore.Mvc;

namespace nswag_ignored_properties.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Animal> Get()
        {
            return Ok();
        }
    }
}
