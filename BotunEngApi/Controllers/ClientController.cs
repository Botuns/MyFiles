using BotunsEngApi.Contexts;
using BotunsEngApi.DTOs.ClientsDTO;
using BotunsEngApi.DTOs.ContractDTO;
using BotunsEngApi.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotunEngApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public IClientServices _clientServices;

        public ClientController(ApplicationContext context, IClientServices clientServices)
        {
            _context = context;
            _clientServices = clientServices;


        }


        [HttpPost]
        [Route("CreateClient")]
        public IActionResult CreateClient([FromForm] ClientRequestModel clientRequest)
        {
            var cclient = _clientServices.GetClientByEmailandPassword(clientRequest.Email, clientRequest.Password);
            if (cclient.IsSuccess == true)
            {
                return BadRequest(cclient);

            }
            else
            {
                _clientServices.CreateClient(clientRequest);
                return Ok(cclient);
            }

        }
        [HttpGet]
        [Route("GetClientContracts")]
        public IActionResult GetClientContracts(int clId)
        {
            if (clId != 0)
            {
                var clientContracts = _clientServices.GetClientContracts(clId);
                if (clientContracts == null)
                {
                    return NotFound(clientContracts);
                }
                return Ok(clientContracts);
            }
            return BadRequest(clId);
        }
        [HttpPut]
        [Route("UpdateClient")]
        public IActionResult UpdateClient([FromForm] ClientRequestModel clientRequest)
        {
            var cclient = _clientServices.GetClientByEmailandPassword(clientRequest.Email, clientRequest.Password);
            if (cclient.IsSuccess == false)
            {
                return BadRequest(cclient);

            }
            else
            {
                _clientServices.UpdateClient(clientRequest);
                return Ok(cclient);
            }
        }
        [HttpPost]
        [Route("CreateContract")]
        public IActionResult CreateContract([FromForm] CreateContractRequestModel request)
        {
            var contract = _clientServices.CreateContract(request);
            if (contract == null) { return BadRequest(contract); }
            return Ok(contract);

        }
    }
}

