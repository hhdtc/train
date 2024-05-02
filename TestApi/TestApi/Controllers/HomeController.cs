using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            return Ok(new { Id = 1, Name="Smith" }) ;
        }

        [HttpGet("{Id:int:max(100)}")]
        public IActionResult Get(int Id)
        {
            if (Id > 0)
            {
                return Ok("number is greater than 0");
            }
            else {
                return BadRequest("number is leq 0");
            }
        }

        

    }
}
