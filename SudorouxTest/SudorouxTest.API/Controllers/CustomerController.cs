using Microsoft.AspNetCore.Mvc;
using SudorouxTest.BL.Dtos;
using SudorouxTest.BL.IServices;



namespace SudorouxTest.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // POST api/customers
        [HttpPost]
        public IActionResult Post([FromBody] CustomerDto dto)
        {
            var result = _customerService.SubmitCustomer(dto);

            return Ok(result);
        }

    }
}
