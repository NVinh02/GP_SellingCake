using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IOrderValidationRepository
    {
        public string checkRedundantWhiteSpace(string obj);
        public string checkCustomerName(string customername);
        public string checkCustomerAddress(string address);
        public string checkCustomerPhoneNumber(string phonenumber);
        public string checkTotalPrice(decimal price);
        public string checkShippingFee(decimal? shippingfee);
        public string checkOrderShippingDate(string date);
        public OrderErrors checkOrder(Order order, bool checkShippingDate);
    }
}
