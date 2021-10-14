using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO
    {
        //Using Singleton Pattern
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<Order> GetOrderByOrderID(int OrderId)
        {
            IEnumerable<Order> orders = null;
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.Where(temp => temp.Orderid == OrderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> GetOrderByStaffID(int StaffId)
        {
            IEnumerable<Order> orders = null;
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.Where(temp => temp.Staffid == StaffId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void AddOrder(Order order)
        {

        }

        public void UpdateOrder(Order order)
        {

        }

        public void DeleteOrder(int orderId)
        {

        }
    }
}
