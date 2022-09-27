using BotunsEngApi.Contexts;
using BotunsEngApi.Implementations.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotunEngApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public AddressRepository _addressRepository;
        public AddressController(ApplicationContext context, AddressRepository addressRepository)
        {
            _context = context;
            _addressRepository = addressRepository;
        }
        [HttpGet]
        [Route("GetAddress")]
        public IActionResult GetAddress(int id)
        {
            var address = _addressRepository.GetAddress(id);
            if(address == null)
            {
                return NotFound(address);
            }
            return Ok(address);
        }
    }
}
