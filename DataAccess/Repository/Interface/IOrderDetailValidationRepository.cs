using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IOrderDetailValidationRepository
    {
        public string checkRedundantWhiteSpace(string obj);
        public string checkTotalPrice(decimal price);
        public string checkOrderDetailAmount(int amount);
        public OrderDetailErrors checkOrderDetail(OrderDetail orderDetail);
    }
}
