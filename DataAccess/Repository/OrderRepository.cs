using BusinessObject.Object;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddNewOrder(Order order) => OrderDAO.Instance.AddNew(order);

        public IEnumerable<Order> GetDeliveryOrderList() => OrderDAO.Instance.GetDeliveryOrder();

        public IEnumerable<Order> GetDeliveryOrderListByStaffID(int staffID) => OrderDAO.Instance.GetDeliveryOrderByStaffID(staffID);

        public IEnumerable<Order> GetOrderByCustomerNameAndStaffId(string customerName, int staffId) => OrderDAO.Instance.GetOrderByCustomerNameAndStaffID(customerName, staffId);

        public IEnumerable<Order> GetOrderByCustomerPhoneAndStaffId(string customerPhone, int staffId) => OrderDAO.Instance.GetOrderByCustomerPhoneAndStaffID(customerPhone, staffId);

        public IEnumerable<Order> GetOrdersByEitherCustomerNameOrPhoneOrBothBasedOnStaffId(string phone, string customerName, int staffID) => OrderDAO.Instance.SearchOrderByPhoneAndCustomerNameBasedOnStaffID(phone, customerName, staffID);

        public Order GetOrderByID(int orderId) => OrderDAO.Instance.GetOrderByID(orderId);

        public Order GetOrderByIDAndStaffID(int orderId, int staffID) => OrderDAO.Instance.GetOrderByIDAndStaffID(orderId,staffID);

        public IEnumerable<Order> GetOrderList() => OrderDAO.Instance.GetOrderList();

        public IEnumerable<Order> GetOrderListByIDAndStaffID(int orderId, int staffId) => OrderDAO.Instance.GetOrderListByIDAndStaffID(orderId, staffId);

        public IEnumerable<Order> GetOrdersByStaffID(int staffID) => OrderDAO.Instance.GetOrderListByStaffID(staffID);

        public IEnumerable<Order> GetTakeawaytOrderList() => OrderDAO.Instance.GetTakeawayOrder();

        public IEnumerable<Order> GetTakeawaytOrderListByStaffId(int staffID) => OrderDAO.Instance.GetTakeawayOrderByStaffID(staffID);

        public void UpdateOrder(Order order) => OrderDAO.Instance.Update(order);
    }
}
