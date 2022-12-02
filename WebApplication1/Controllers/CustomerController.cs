using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            var result = _customerService.AddCustomer(customer);
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }
    }
}
