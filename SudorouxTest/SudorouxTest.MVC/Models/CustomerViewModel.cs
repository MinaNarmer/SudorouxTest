
using System;
using System.ComponentModel.DataAnnotations;

namespace SudorouxTest.MVC.Models
{
    public class CustomerViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public bool Subscribed { get; set; }
        [Required]
        public DateTime DOB { get; set; }
    }
}
