using ApiPractical.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPractical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        CustomerRepository CustomerRepository = new CustomerRepository();
        [HttpGet]
        [Route("GetCustomerByFirstName")]
        public IActionResult GetCustomerByFirstName(string firstname)
        {
            var customer = CustomerRepository.GetCustomerByFirstName(firstname);
            if (customer != null)
            {
                return Ok(customer);
            }
            return NotFound("Customer Not Found");

        }
        [HttpGet]
        [Route("GetAllCustomers")]

        public IActionResult GetAllCustomers()
        {
            var customers = CustomerRepository.GetAllCustomers();
            if (customers != null)
            {
                return Ok(customers);
            }
            return NotFound("Opps! failed to find customers");

        }
        [HttpGet]
        [Route("GetNameByLetter")]
        public IActionResult GetNameByLetter(string a)
        {
            var customers = CustomerRepository.GetNameByLetter(a);
            if (customers != null)
            {
                return Ok(customers);
            }
            return NotFound("Opps! failed to find customers");

        }

    }
}
