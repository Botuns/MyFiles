using BotunsEntities.DTO;
using BotunsEntities.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BotunsEntities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractServices _contractService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ContractController(IContractServices contractService, IWebHostEnvironment webHostEnvironment)
        {
            _contractService = contractService;
            _webHostEnvironment = webHostEnvironment;
        }
        [Authorize]
        [HttpPost("InitiateContract")]
        public async Task<IActionResult> InitiateContract([FromForm] InitiateContractRequest model)
        {
            var getUser = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var userId = int.Parse(getUser);
            model.userId = userId;
            var contract = await _contractService.InitiateContract(model);
            if (contract == null)
            {
                return BadRequest(contract);

            }
            return Ok(contract);

        }
    }
}
