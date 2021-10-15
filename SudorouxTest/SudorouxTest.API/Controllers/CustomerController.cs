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

        /// <summary>
        /// This Api convert the input model to json 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns> Returns the converted object</returns>
        [HttpPost]
        public IActionResult Post([FromBody] CustomerDto dto)
        {
            var result = _customerService.SubmitCustomer(dto);

            return Ok(result);
        }

    }
}
