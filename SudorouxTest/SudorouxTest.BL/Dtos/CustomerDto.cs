
using System;

namespace SudorouxTest.BL.Dtos
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool Subscribed { get; set; }
        public DateTime DOB { get; set; }
    }
}
