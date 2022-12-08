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
        public IActionResult GetUsers()
        {
            return new JsonResult(Enumerable.Empty<User>().Append(new User()
            {
                FirstName = "Dill",
                LastName = "Doe"
            }));
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUser(int id)
        {
            return new JsonResult((new User()
            {
                FirstName = "Dill",
                LastName = "Doe"
            }));
        }
    }
}
