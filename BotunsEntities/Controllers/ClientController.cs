using BotunsEntities.DTO;
using BotunsEntities.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BotunsEntities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ClientController(IClientService clientService, IWebHostEnvironment webHostEnvironment)
        {
            _clientService = clientService;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpPost("RegisterClient")]
        public async Task<IActionResult> RegisterClient([FromForm] ClientRequestModel model)
        {
            var regClient = await _clientService.RegisterClient(model);
            if (regClient.IsSuccess == false)
            {
                return BadRequest(regClient);
            }
            return Ok(regClient);
        }
        
    }
}
