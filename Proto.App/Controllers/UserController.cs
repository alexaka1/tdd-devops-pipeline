using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proto.App.Models;

namespace Proto.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        [HttpGet("")]
        public async Task<IActionResult> GetUsersAsync()
        {
            using var context = new Proto.App.Context.ApppppppppppppppppppppContext();

            return new JsonResult(await context.Users.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUser(int id)
        {
            using var context = new Proto.App.Context.ApppppppppppppppppppppContext();
            var user = await context.Users.SingleOrDefaultAsync(x=> x.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            return new JsonResult(user);
        }
    }
}
