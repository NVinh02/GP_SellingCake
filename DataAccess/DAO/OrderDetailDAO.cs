using BusinessObject.DBContext;
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
        private OrderDetailDAO() { }
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
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailByOrderID(int orderID)
        {
            var orders = new List<OrderDetail>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.OrderDetails.ToList().FindAll(orderd => orderd.Orderid == orderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void AddNew(OrderDetail detail)
        {
            try
            {
                using var context = new CakeManagementContext();

                context.OrderDetails.Add(detail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail detail)
        {
            try
            {
                using var context = new CakeManagementContext();

                context.OrderDetails.Update(detail);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(OrderDetail detail)
        {
            try
            {
                using var context = new CakeManagementContext();

                context.OrderDetails.Remove(detail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAmount(OrderDetail detail)
        {
            try
            {
                using var context = new CakeManagementContext();
                GetOrderDetailByOrderID(detail.Orderid);


                context.OrderDetails.Update(detail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
