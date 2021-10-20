using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Orderid { get; set; }
        public int? Staffid { get; set; }
        public decimal Totalprice { get; set; }
        public string Customername { get; set; }
        public string Customeraddress { get; set; }
        public string Customerphonenumber { get; set; }
        public decimal? Shippingfee { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Shippingdate { get; set; }

        public virtual User Staff { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
