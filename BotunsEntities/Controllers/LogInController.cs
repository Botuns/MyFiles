using BotunsEntities.Authentication;
using BotunsEntities.DTO;
using BotunsEntities.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BotunsEntities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJWTAuthentication _auth;
        public LogInController(IUserService userService,IJWTAuthentication auth)
        {
            _userService = userService;
            _auth = auth;
           
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] UserRequestModel model)
        {
            var login = await _userService.Login(model);
            if (!login.IsSuccess)
            {
                return BadRequest(login);
            }
            var token = _auth.GenerateToken(login);
            var response = new LoginResponse
            {
                Data = login,
                Token = token
            };
            return Ok(response);
        }
    }
}
