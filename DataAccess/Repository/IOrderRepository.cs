using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrdersByStaffID(int staffID);
        IEnumerable<Order> GetOrderList();
        IEnumerable<Order> GetDeliveryOrderList();
        IEnumerable<Order> GetDeliveryOrderListByStaffID(int staffID);
        IEnumerable<Order> GetTakeawaytOrderList();
        IEnumerable<Order> GetTakeawaytOrderListByStaffId(int staffID);
        IEnumerable<Order> GetOrdersByEitherCustomerNameOrPhoneOrBoth(string phone, string customerName);
        IEnumerable<Order> GetOrdersByEitherCustomerNameOrPhoneOrBothBasedOnStaffId(string phone, string customerName, int staffID);
        IEnumerable<Order> GetOrderListByIDAndStaffID(int orderId, int staffId);
        public void AddNewOrder(Order order);
        public void UpdateOrder(Order order);
        public Order GetOrderByID(int orderId);
        public Order GetOrderByIDAndStaffID(int orderId, int staffId);
    }
}
