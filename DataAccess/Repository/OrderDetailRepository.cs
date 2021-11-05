using BusinessObject.Object;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {

        public void InsertNewOrderDetail(OrderDetail detail) => OrderDetailDAO.Instance.AddNew(detail);

        public void UpdateOrder(OrderDetail detail) => OrderDetailDAO.Instance.Update(detail);

        public IEnumerable<OrderDetail> GetOrderDetailsByOrderID(int orderID) => OrderDetailDAO.Instance.GetOrderDetailByOrderID(orderID);

        public void RemoveOrderDetails(OrderDetail detail) => OrderDetailDAO.Instance.Remove(detail);
    }
}
