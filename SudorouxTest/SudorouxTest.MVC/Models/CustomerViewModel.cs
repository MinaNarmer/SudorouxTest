
using System;
using System.ComponentModel.DataAnnotations;

namespace SudorouxTest.MVC.Models
{
    public class CustomerViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Subscribed")]
        public bool Subscribed { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
    }
}
