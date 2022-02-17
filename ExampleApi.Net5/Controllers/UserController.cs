using ExampleApi.Net5.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Net5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(nameof(GetUserById) + "/{userId}")]
        public IActionResult GetUserById(int userId)
        {
            return Ok();
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpPost(nameof(AddUser))]
        public IActionResult AddUser(User model)
        {
            return Ok();
        }
        [HttpPut(nameof(UpdateUser))]
        public IActionResult UpdateUser(User model)
        {
            return Ok();
        }
        [HttpDelete(nameof(DeleteUser) + "/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            return Ok();
        }
    }
}
