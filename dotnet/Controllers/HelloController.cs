using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {   
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello to my friends!";
        }
    }
}
