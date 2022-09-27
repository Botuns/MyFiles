using BotunsEngApi.Contexts;
using BotunsEngApi.DTOs.ContractDTO;
using BotunsEngApi.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BotunEngApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public IContractServices _contractServices;
        public ContractController(ApplicationContext context, IContractServices contractServices)
        {
            _context = context;
            _contractServices = contractServices;
        }
        [HttpPost]
        [Route("CreateContract")]
        public IActionResult CreateContract([FromForm] CreateContractRequestModel request)
        {
            var contract =  _contractServices.CreateContract(request);
            if( contract == null) { return BadRequest(contract); }
            return Ok(contract);

        }
    }
}
