using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_api_dnet.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace crud_api_dnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(User user)
        {
            var response = await _userService.Register(user, user.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}