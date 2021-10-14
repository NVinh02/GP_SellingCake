using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<OrderDetail> GetOrderByOrderID(int OrderId)
        {
            IEnumerable<OrderDetail> orders = null;
            try
            {
                using var context = new CakeManagementContext();
                orders = context.OrderDetails.Where(temp => temp.Orderid == OrderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<OrderDetail> GetOrderByCakeID(int CakeId)
        {
            IEnumerable<OrderDetail> orders = null;
            try
            {
                using var context = new CakeManagementContext();
                orders = context.OrderDetails.Where(temp => temp.Cakeid == CakeId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void AddOrder(OrderDetail order)
        {

        }

        public void UpdateOrder(OrderDetail order)
        {

        }

        public void DeleteOrderByOrderID(int orderId)
        {

        }
    }
}
