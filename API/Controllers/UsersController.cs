using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPro.Business.Abstraction.Auth;

namespace SmartPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAllUser();
            if (result.Success)
                return Ok(result);
            
            return BadRequest(result);
        }
    }
}
