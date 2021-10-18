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
    public class OrderDetailValidationReposiroty : IOrderDetailValidationRepository
    {
        public OrderDetailErrors checkOrderDetail(OrderDetail orderDetail)
        => OrderValidation.Instance.checkOrderDetail(orderDetail);

        public string checkOrderDetailAmount(int amount)
        => OrderValidation.Instance.checkOrderDetailAmount(amount);

        public string checkRedundantWhiteSpace(string obj)
        => OrderValidation.Instance.checkRedundantWhiteSpace(obj);

        public string checkTotalPrice(decimal price)
        => OrderValidation.Instance.checkTotalPrice(price);
    }
}
