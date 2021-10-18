using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess.Validation
{
    public class OrderValidation
    {
        #region Initialized Objects
        private ValidationData validation = null;
        private static OrderValidation instance = null;
        private static readonly object instanceLock = new object();
        private OrderValidation() { }
        public static OrderValidation Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderValidation();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Note
        //Format for cmt on each function 
        //1st cmt: Specify what ur validation code is used for which class (total of five: Cake, Employee, Order, Order Detail, with Common being a universal function
        //2nd cmt: Briefly explain what the function does, if the name of the function name is alreay self explainatory just type it here
        //3rd cmt: Further elaborate on what the function does (if needed)
        //4th cmt: Give a specification on what does ur function checking (the range, reg ex, ...)
        //also, everything that is hard code in this project won't be checked in this validation class
        #endregion

        #region Common
        //For Common
        //Check if the text field is redundant whitespace
        public string checkRedundantWhiteSpace(string obj)
        {
            Regex trimmer = new Regex(@"\\s\\s+");
            return obj = trimmer.Replace(obj.Trim(), " ");
        }
        #endregion

        #region Customer
        /*--------------------------------------------------------------------------------*/
        //For Customer
        //Checking Customer name
        //Check length and format of customer name
        //Specification: Allow normal characters, whitespaces, length 1 to 50
        public string checkCustomerName(string customername)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("Customer Name", customername, true, 1, 50, @"^[a-zA-Z\s]{1,50}$");
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Customer
        //Check Customer address
        //Check length and format of address
        //Specification: Allow normal characters, numbers, whitespaces, character "/" "," , length 1 - 50
        public string checkCustomerAddress(string address)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("address", address, true, 1, 100, @"^[a-zA-Z0-9/,\s]{1,50}$");
            return error;
        }
        #endregion

        #region Order
        /*--------------------------------------------------------------------------------*/
        //For Order
        //Check Customer Phone Number
        //Check length and format of phone number
        //Specification: exactly 10 numbers
        public string checkCustomerPhoneNumber(string phonenumber)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("phone number", phonenumber, true, 1, 10, @"^[0-9]{10}$");
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Order
        //Check Order price
        //Check price of order range 1 - 100,000,000 VND
        //Specification: compare number against range
        public string checkTotalPrice(decimal price)
        {
            validation = new ValidationData();
            string checkNumber = Convert.ToString(price);
            string error = validation.CheckNumber("Price", checkNumber, 1, 10000000, true, false);
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Order
        //Check shipping fee
        //Shipping fee values are 15,000 VND and 30,000 VND
        //Specification: Only accept 2 values: 15,000 and 30,000
       public string checkShippingFee(decimal? shippingfee)
        {
            validation = new ValidationData();
            string checkNumber = Convert.ToString(shippingfee);
            string error = validation.CheckNumber("Shipping Fee", checkNumber, 15000, 30000, true, false);
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Order 
        //Check Date: Shipping Date
        //Check if Date entered is of valid format (yyyy - MM - dd) and is not null
        //Specification: compare string date against format
       public string checkOrderShippingDate(string date)
        {
            validation = new ValidationData();
            string error = validation.checkDate("Shipping Date", date, true);
            return error;
        }
        #endregion

        #region OrderDetail
        /*--------------------------------------------------------------------------------*/
        //For Order detail
        //Checking cake amount 
        //Check amount range 1 - 10
        //Specification: the number has to be in the range of 1 to 10
        public string checkOrderDetailAmount(int amount)
        {
            validation = new ValidationData();
            string checkNumber = Convert.ToString(amount);
            string error = validation.CheckNumber("Amount", checkNumber, 1, 10, true, true);
            return error;
        }
        #endregion

        #region Check Overall
        //Check Order
        public OrderErrors checkOrder(Order order, bool checkShippingDate)
        {
            OrderErrors orderErrors = new OrderErrors();
            orderErrors.totalPriceError = checkTotalPrice(order.Totalprice);
            orderErrors.customerNameError = checkCustomerName(order.Customername);
            orderErrors.customerAddressError = checkCustomerAddress(order.Customeraddress);
            orderErrors.customerPhonenumberError = checkCustomerAddress(order.Customerphonenumber);
            // Xem xét lại
            if (checkShippingDate)
            {
                orderErrors.shippingDateError = checkOrderShippingDate(Convert.ToString(order.Shippingdate));
                orderErrors.shippingFeeError = checkShippingFee(order.Shippingfee);
            }
            if (orderErrors.isEmpty(checkShippingDate))
                orderErrors = null;
            return orderErrors;            
        }

        //Check Order Detail
        public OrderDetailErrors checkOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailErrors orderDetailErrors = new OrderDetailErrors();
            orderDetailErrors.totalPriceError = checkTotalPrice(orderDetail.Totalprice);
            orderDetailErrors.amountError = checkOrderDetailAmount(orderDetail.Amount);
            
            if (orderDetailErrors.isEmpty())
                orderDetailErrors = null;
            return orderDetailErrors;
        }
        #endregion
    }
}
