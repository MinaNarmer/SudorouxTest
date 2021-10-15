using Newtonsoft.Json;
using SudorouxTest.BL.Dtos;
using SudorouxTest.BL.IServices;

namespace SudorouxTest.BL.Services
{
    public class CustomerService : ICustomerService
    {
        public string SubmitCustomer(CustomerDto dto)
        {
            var result = JsonConvert.SerializeObject(dto);
            return result ;
        }
    }
}
