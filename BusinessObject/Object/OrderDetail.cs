using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CakeShopLibrary.BusinessObject
{
    class OrderDetail
    {
        //OrderID
        [Required(ErrorMessage = "Order ID required.")]
        public int OrderID { get; set; }

        //CakeID
        [Required(ErrorMessage = "Cake ID required.")]
        public int CakeID { get; set; }

        //Amount
        [Required(ErrorMessage = "Amount of cakes required.")]
        [Range(1, 9999, ErrorMessage ="Amount must be between 1 - 9999")]
        public int Amount { get; set; }

        //TotalPrice
        [Required(ErrorMessage = "Price required.")]
        [Range(1000, 10000000, ErrorMessage = "Price must be between 1,000 -> 10,000,000 VND")]
        public decimal TotalPrice { get; set; }

    }
}
