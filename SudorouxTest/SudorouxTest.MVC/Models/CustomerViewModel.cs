
using System;

namespace SudorouxTest.MVC.Models
{
    public class CustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool Subscribed { get; set; }
        public DateTime DOB { get; set; }
    }
}
