using System;
using System.ComponentModel.DataAnnotations;

namespace CakeShopLibrary.BusinessObject
{
    class Order
    {
        //OrderID
        [Required(ErrorMessage = "Order ID required.")]
        public int OrderID { get; set; }

        //EmployeeID
        [Required(ErrorMessage = "Employee ID required.")]
        public int EmployeeID { get; set; }

        //TotalPrice
        [Required(ErrorMessage = "Total price required")]
        [Range(1000,10000000, ErrorMessage ="Price must be between 1,000 -> 10,000,000 VND")]
        public int TotalPrice { get; set; }

        //CustomerName
        [Required(ErrorMessage = "Customer Name required.")]
        [StringLength(50, ErrorMessage = "Customer name length < 50")]
        public String CustomerName { get; set; }

        //CustomerEmail
        [Required(ErrorMessage = "Customer Email required.")]
        [StringLength(50, ErrorMessage = "Customer Email length < 50")]
        public String CustomerEmail { get; set; }

        //CustomerAddress
        [Required(ErrorMessage = "Customer address required.")]
        [StringLength(100, ErrorMessage = "Customer Address length < 100")]
        public int CustomerAddress { get; set; }

        //CustomerPhoneNumber
        [Required]
        [StringLength(12, ErrorMessage = "Phone number length must be 10 to 12", MinimumLength = 10)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Numbers only.")]
        public string CustomerPhoneNumber { get; set; }

        //Shipping fee
        [Required(ErrorMessage = "Shipping fee required.")]
        [Range(1000, 50000, ErrorMessage ="Shipping fee must be between 1,000 -> 50,000 VND")]
        public decimal ShippingFee { get; set; }

        //Date created
        [Required(ErrorMessage = "Date created of order required.")]
        public DateTime CreatedDate { get; set; }
    }
}
