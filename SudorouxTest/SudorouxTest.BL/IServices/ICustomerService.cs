
using SudorouxTest.BL.Dtos;

namespace SudorouxTest.BL.IServices
{
    public interface ICustomerService
    {
        byte[] SubmitCustomer(CustomerDto dto);
    }
}
