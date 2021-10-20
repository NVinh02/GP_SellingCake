using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class OrderDetail
    {
        public int Orderid { get; set; }
        public int Cakeid { get; set; }
        public int Amount { get; set; }
        public decimal Totalprice { get; set; }

        public virtual Cake Cake { get; set; }
        public virtual Order Order { get; set; }
    }
}
