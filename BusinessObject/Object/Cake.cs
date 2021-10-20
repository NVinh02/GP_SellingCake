using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class Cake
    {
        public Cake()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Cakeid { get; set; }
        public string Cakename { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Category { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
