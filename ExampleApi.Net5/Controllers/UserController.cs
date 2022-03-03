using ExampleApi.Net5.Business.UserService;
using ExampleApi.Net5.Data.Dto;
using ExampleApi.Net5.Data.Entities;
using ExampleApi.Net5.DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Net5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        [HttpGet(nameof(GetUserById) + "/{userId}")]
        public IActionResult GetUserById(int userId)
        {
            try
            {
                userService.Get(userId);
                return Ok();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            try
            {
                var data = userService.GetAll();
                return Ok(data);

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost(nameof(AddUser))]
        public IActionResult AddUser(UserDto model)
        {
            try
            {
                if (model != null)
                {
                    userService.Add(model);
                    return Ok();
                }
                else
                    return BadRequest();
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut(nameof(UpdateUser))]
        public IActionResult UpdateUser(UserDto model)
        {
            try
            {
                if (model != null)
                {
                    userService.Update(model);
                    return Ok(model);
                }
                else
                    return BadRequest();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete(nameof(DeleteUser) + "/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            try
            {
                var model = userService.Get(userId);
                if (model != null)
                {
                    userService.Delete(model);
                    return Ok(model);
                }
                else
                    return BadRequest();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
