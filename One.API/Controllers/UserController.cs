using Microsoft.AspNetCore.Mvc;
using One.Application.Dto;
using One.Application.Interfaces;

namespace One.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDetailDto>>> GetUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult> AddUser(UserDetailDto obj)
        {
            if (obj == null) {
                return BadRequest();
            }

            await _userService.CreateUserAsync(obj);
            return Ok();
        }
    }
}
