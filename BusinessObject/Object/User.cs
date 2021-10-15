using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject.Object
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Userid { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username must be between 1 to 50 characters")]
        [RegularExpression(@"^[A-Za-z0-9]*$", ErrorMessage = "Username can only contain alphabet characters and numbers")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [StringLength(30, ErrorMessage = "Password cannot exceed 30 characters")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "Password cannot contain whitespace")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(100, ErrorMessage = "Fullname cannot exceed 100 characters")]
        [RegularExpression(@"^[A-Za-z\s]*$", ErrorMessage = "Name cannnot contain special characters or numbers")]
        public string Fullname { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Phone Number must be 10 numbers", MinimumLength = 10)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone Number must only contained number")]
        public string Phonenumber { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Address is 50 characters maximum")]
        [RegularExpression(@"^[A-Za-z0-9/\s]*$", ErrorMessage = "Address can only contain alphabet characters, number, whitespace and this \"/\" special character")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong Email Address format")]
        [RegularExpression(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$", ErrorMessage = "Email has to follow this format abc@xyz.t(.v)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Role must be specified")]
        public string Role { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
