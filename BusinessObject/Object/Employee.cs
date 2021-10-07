using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShopLibrary.BusinessObject
{
    class Employee
    {
        [Required(ErrorMessage = "EmployeeId is required")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username must be between 1 to 50 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "Password cannot exceed 30 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(100, ErrorMessage = "Fullname cannot exceed 100 characters")]
        public string Fullname { get; set; }

        //Phone numbers are permitted to be expressed with digits and the characters " -.()" plus an extension marked with "ext.", "ext", or "x".
        //Phone numbers sometimes contain alpha characters. For example, "1 (800) LOAN-YES" and "1 (800) MICROSOFT"
        //can both be dialed as phone numbers in the United States. --> IS NOT USABLE FOR OUR PROJECT
        [Required]
        [StringLength(12, ErrorMessage = "Phone Number must be 10 to 12 numbers", MinimumLength = 10)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone Number must only contained number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong Email Address format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Role must be specified")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Status must be specified")]
        public Boolean IsEnable { get; set; }
    }
}
