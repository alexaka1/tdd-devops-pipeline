using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proto.App.Models;

namespace Proto.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("")]
        public IActionResult GetUser()
        {
            //return Ok();
            return new JsonResult(new User()
            {
                FirstName = "Dill",
                LastName = "Doe"
            });
        }
    }
}
