using System.Threading.Tasks;
using AspnetCoreSPA.Service.Interface;
using Microsoft.AspNetCore.Mvc;
namespace AspnetCoreSPA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        //GET: api/Customer/
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _customerService.GetCustomers();

            if (customers == null)
            {
                return NotFound();
            }

            return Ok(customers);
        }
    }
}
