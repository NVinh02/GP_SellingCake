using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        void InsertNewOrderDetail(OrderDetail detail);

        void UpdateOrder(OrderDetail detail);

        IEnumerable<OrderDetail> GetOrderDetailsByOrderID(int orderID);

        void RemoveOrderDetails(OrderDetail detail);
    }
}
