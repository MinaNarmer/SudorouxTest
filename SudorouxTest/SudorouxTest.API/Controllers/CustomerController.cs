using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SudorouxTest.BL.Dtos;
using SudorouxTest.BL.IServices;
using System.Collections;

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
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] CustomerDto dto)
        {
            var result = _customerService.SubmitCustomer(dto);

            return Ok(result);
        }

    }
}
