using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository.Interface;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implement
{
    class OrderValidationReposiroty : IOrderValidationRepository
    {
        public string checkCustomerAddress(string address)
        => OrderValidation.Instance.checkCustomerAddress(address);

        public string checkCustomerName(string customername)
        => OrderValidation.Instance.checkCustomerName(customername);

        public string checkCustomerPhoneNumber(string phonenumber)
        => OrderValidation.Instance.checkCustomerPhoneNumber(phonenumber);

        public OrderErrors checkOrder(Order order, bool checkShippingDate)
        => OrderValidation.Instance.checkOrder(order, checkShippingDate);

        public string checkOrderShippingDate(string date)
        => OrderValidation.Instance.checkOrderShippingDate(date);

        public string checkRedundantWhiteSpace(string obj)
        => OrderValidation.Instance.checkRedundantWhiteSpace(obj);

        public string checkShippingFee(decimal? shippingfee)
        => OrderValidation.Instance.checkShippingFee(shippingfee);

        public string checkTotalPrice(decimal price)
        => OrderValidation.Instance.checkTotalPrice(price);
    }
}
