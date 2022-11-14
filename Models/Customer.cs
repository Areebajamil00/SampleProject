using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SampleProject.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Your Name")]
        [StringLength(15, ErrorMessage = "Name should be less than or equal to Fifteen characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Your Address")]
        [StringLength(50, ErrorMessage = "Name should be less than or equal to fifty characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter Your Gender")]
        [StringLength(10, ErrorMessage = "Name should be less than or equal to ten characters.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter Your City")]
        [StringLength(10, ErrorMessage = "Name should be less than or equal to ten characters.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter Your Country")]
        [StringLength(10, ErrorMessage = "Name should be less than or equal to ten characters.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Your must provide a Mobile Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Mobile number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Enter Your Mail ID")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
    }
}