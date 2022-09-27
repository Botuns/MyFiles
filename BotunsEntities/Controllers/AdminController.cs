using BotunsEntities.DTO;
using BotunsEntities.Interfaces.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BotunsEntities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AdminController(IAdminService adminService, IWebHostEnvironment webHostEnvironment)
        {
            _adminService = adminService;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpPost("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromForm] AdminRequestModel model)
        {
            var registerAdmin = await _adminService.RegisterAdmin(model);
            if (registerAdmin.IsSuccess == false)
            {
                return BadRequest(registerAdmin);
            }
            return Ok(registerAdmin);
        }

    }
}
