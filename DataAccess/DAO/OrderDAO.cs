using BusinessObject.DBContext;
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
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetOrderListByStaffID(int staffID)
        {
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().FindAll(order => order.Staffid == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> GetOrderList()
        {
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void AddNew(Order order)
        {
            try
            {
                using var context = new CakeManagementContext();
                var tmp = context.Orders.ToList().Find(c => c.Orderid == order.Orderid);
                if (tmp != null)
                {
                    throw new Exception("Order ID already exist");
                }
                else
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Order GetOrderByID(int orderID)
        {
            var orders = new Order();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().SingleOrDefault(order => order.Orderid == orderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public Order GetOrderByIDAndStaffID(int orderID, int staffID)
        {
            var orders = new Order();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().SingleOrDefault(order => order.Orderid == orderID && order.Staffid == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void Update(Order order)
        {
            try
            {
                Order exist = GetOrderByID(order.Orderid);
                if (exist != null)
                {
                    using var context = new CakeManagementContext();
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This order does not exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Order> GetDeliveryOrder()
        {
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().FindAll(o => o.Shippingfee == 30000);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> GetDeliveryOrderByStaffID(int staffID)
        {
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().FindAll(o => o.Shippingfee == 30000 && o.Staffid == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> GetTakeawayOrder()
        {
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().FindAll(o => o.Shippingfee == 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> GetTakeawayOrderByStaffID(int staffID)
        {
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().FindAll(o => o.Shippingfee == 0 && o.Staffid == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> GetOrderListByIDAndStaffID(int orderId, int staffID)
        {
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();
                orders = context.Orders.ToList().FindAll(order => order.Orderid == orderId && order.Staffid == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> SearchOrderByPhoneAndCustomerNameBasedOnStaffID(string CustomerPhone, string NameValue, int staffID)
        {
            //List<Cake> cakes = new List<Cake>();
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();

                if (CustomerPhone != "" && NameValue != "")
                {
                    orders = context.Orders.ToList().FindAll
                        (c => c.Customerphonenumber.Contains(CustomerPhone) && c.Customername.ToLower().Contains(NameValue.ToLower()) && c.Staffid == staffID);
                }
                else if (NameValue != "")
                {
                    orders = context.Orders.ToList().FindAll
                        (c => c.Customername.ToLower().Contains(NameValue.ToLower()) && c.Staffid == staffID);
                }
                else if (CustomerPhone != "")
                {
                    orders = context.Orders.ToList().FindAll
                        (c => c.Customerphonenumber.Contains(CustomerPhone) && c.Staffid == staffID);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> SearchOrderByPhoneAndCustomerName(string CustomerPhone, string NameValue)
        {
            //List<Cake> cakes = new List<Cake>();
            var orders = new List<Order>();
            try
            {
                using var context = new CakeManagementContext();

                if (CustomerPhone != "" && NameValue != "")
                {
                    orders = context.Orders.ToList().FindAll
                        (c => c.Customerphonenumber.Contains(CustomerPhone) && c.Customername.ToLower().Contains(NameValue.ToLower()));
                }
                else if (NameValue != "")
                {
                    orders = context.Orders.ToList().FindAll
                        (c => c.Customername.ToLower().Contains(NameValue.ToLower()));
                }
                else if (CustomerPhone != "")
                {
                    orders = context.Orders.ToList().FindAll
                        (c => c.Customerphonenumber.Contains(CustomerPhone));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
    }
}
