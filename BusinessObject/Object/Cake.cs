using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShopLibrary.BusinessObject
{
    class Cake
    {
        [Required(ErrorMessage = "CakeId is required")]
        public int CakeId { get; set; }

        [Required(ErrorMessage = "CakeName is required")]
        [StringLength(100, ErrorMessage = "Cannot exceed 100 characters for Cake Name")]
        public string CakeName { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1000, 100000000, ErrorMessage = "Price must be between 1 000 VND to maximum of 10 000 000 VND")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0, 100, ErrorMessage = "Amount must between 0 to 100")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Category must be specified")]
        [StringLength(30, ErrorMessage = "Invalid Lenght for Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public Boolean IsEnable { get; set; }


    }
}
