using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace BusinessObject.ObjectValidation
//Format for cmt on each function 
//1st cmt: Specify what ur validation code is used for which class (total of five: Cake, Employee, Order, Order Detail, with Common being a universal function
//2nd cmt: Briefly explain what the function does, if the name of the function name is alreay self explainatory just type it here
//3rd cmt: Further elaborate on what the function does (if needed)
//4th cmt: Give a specification on what does ur function checking (the range, reg ex, ...)
//also, everything that is hard code in this project won't be checked in this validation class
{
    public class Validation
    {
        //For Cake
        //Checking Cake Name
        //Including checking both the length and regex as well
        //Specification: No special character and number, from 1 to 100 characters
        public static bool checkCakeName (string s)
        {
            var regex = new Regex(@"^[a-zA-Z\s]{1,100}$");
            if (regex.IsMatch(s))
            {
                return true;
            } else
            {
                return false;
            }
        }

        //For Common
        //Check if string is ok to parse into integer
        //Unlimit character
        public static bool checkIntegerParse(string s)
        {
            var regex = new Regex(@"^[0-9]*$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //For Common
        //Check if string is ok to parse into decimal
        //Unlimit character
        public static bool checkDecimalParse(string s)
        {
            var regex = new Regex(@"^[0-9]+[.]{0,1}[0-9]{1,4}$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Common
        //Check if the text field is blank or not
        //Already include Trim() for exccessive whitespace
        public static bool checkBlank(string input)
        {
            return String.IsNullOrEmpty(input.Trim());
        }

        /*--------------------------------------------------------------------------------*/
        //For Cake
        //Checking Cake Price
        //Since it's already int --> no regex need to be check
        //Specification: the number has to be in the range of 1 to 10 000 000
        public static bool checkCakePrice (decimal price)
        {
            if (price<1 || price >10000000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Cake
        //Checking Cake Ammount
        //Since it's already int --> no regex need to be check
        //Specification: the number has to be in the range of 1 to 1 000
        public static bool checkCakeAmount(int amount)
        {
            if (amount < 1 || amount > 1000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Employee
        //Checking Employee Username
        //Including checking both the length and regex as well
        //Specification: No special character and whitespace, from 1 to 50 characters
        public static bool checkEmployeeUsername(string s)
        {
            var regex = new Regex(@"^[a-zA-Z0-9]{1,50}$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Employee
        //Checking Employee Password
        //Including checking both the length and regex as well
        //Specification: No whitespace, from 1 to 30 characters
        public static bool checkEmployeePassword(string s)
        {
            var regex = new Regex(@"^[^\s]+$");
            if (s.Length > 30 || s.Length < 1)
            {
                return false;
            } else
            {
                if (regex.IsMatch(s))
                {
                    return false;
                }
            }
            return true;
        }

        /*--------------------------------------------------------------------------------*/
        //For Employee
        //Checking Employee Fullname
        //Including checking both the length and regex as well
        //Specification: No special character and number, from 1 to 100 characters
        public static bool checkEmployeeFullName(string s)
        {
            var regex = new Regex(@"^[a-zA-Z\s]{1,100}$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Employee
        //Checking Employee Phone Number
        //Including checking both the length and regex as well
        //Specification: Only number, exactly 10 characrers
        public static bool checkEmployeePhoneNumber(string s)
        {
            var regex = new Regex(@"^[0-9]{10}$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Employee
        //Checking Employee Address
        //Including checking both the length and regex as well
        //Specification: Address can only contain alphabet characters, number, whitespace and this "/" special character, from 1 to 50 characters
        public static bool checkEmployeeAddress(string s)
        {
            var regex = new Regex(@"^[A-Za-z0-9/\s]*$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Employee
        //Checking Employee Email
        //Including checking both the length and regex as well
        //Specification: Follow this format abc@xyz.t(.v) with anything in () is optional
        public static bool checkEmployeeEmail(string s)
        {
            var regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Customer
        //Checking Customer name
        //Check length and format of customer name
        //Specification: Allow normal characters, whitespaces, length 1 to 100
        public static bool checkCustomerName(string s)
        {
            var regex = new Regex(@"^[a-zA-Z\s]{1,100}$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Customer
        //Check Customer address
        //Check length and format of address
        //Specification: Allow normal characters, numbers, whitespaces, character "/" "," , length 1 - 100 
        public static bool checkCustomerAddress(string s)
        {
            var regex = new Regex(@"^[a-zA-Z0-9/,\s]{1,100}$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Order
        //Check Customer Phone Number
        //Check length and format of phone number
        //Specification: exactly 10 numbers
        public static bool checkCustomerPhoneNumber(string s)
        {
            var regex = new Regex(@"^[0-9]{10}$");
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Order
        //Check Order price
        //Check price of order range 1 - 100,000,000 VND
        //Specification: compare number against range
        public static bool checkTotalPrice(int price)
        {
            if (price < 1 || price > 100000000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Order detail
        //Checking cake amount 
        //Check amount range 1 - 10
        //Specification: the number has to be in the range of 1 to 10
        public static bool checkOrderAmount(int amount)
        {
            if (amount < 1 || amount > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Order
        //Check shipping fee
        //Shipping fee values are 15,000 VND and 30,000 VND
        //Specification: Only accept 2 values: 15,000 and 30,000
        public static bool checkShippingFee(decimal fee)
        {
            if (fee == 15000 || fee == 30000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*--------------------------------------------------------------------------------*/
        //For Order 
        //Check Date: Shipping Date
        //Check if Date entered is of valid format (yyyy - MM - dd) and is not null
        //Specification: compare string date against format
        public static bool checkDate(string date)
        {
            //DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            if (String.IsNullOrEmpty (date.Trim()) )
            {
                return false;
            }

            DateTime dt;
            string format = "yyyy-MM-dd";
            if (DateTime.TryParseExact(date, format,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
