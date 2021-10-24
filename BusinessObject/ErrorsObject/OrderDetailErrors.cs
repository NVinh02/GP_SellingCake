using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.ErrorsObject
{
    public class OrderDetailErrors
    {
        public string amountError { get; set; }
        public string totalPriceError { get; set; }

        public bool isEmpty()
        {
            return checkEmpty(totalPriceError, false)
                && checkEmpty(amountError, false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(totalPriceError, true))
                message += totalPriceError + "\n";
            if (checkEmpty(amountError, true))
                message += amountError;
            return message;
        }

        public bool checkEmpty(string name, bool? IsNotEmpty)
        {
            if (IsNotEmpty == true)
            {
                return !String.IsNullOrEmpty(name);
            }
            return String.IsNullOrEmpty(name);
        }
    }
}
