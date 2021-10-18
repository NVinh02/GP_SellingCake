using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Errors
{
    public class OrderErrors
    {
        public string totalPriceError { get; set; }
        public string customerNameError { get; set; }
        public string customerAddressError { get; set; }
        public string customerPhonenumberError { get; set; }
        public string shippingFeeError { get; set; }
        public string shippingDateError { get; set; }

        public bool isEmpty(bool checkShippingDate)
        {
            if (checkShippingDate)
            {
                return checkEmpty(totalPriceError, false)
                && checkEmpty(customerNameError, false)
                && checkEmpty(customerAddressError, false)
                && checkEmpty(customerPhonenumberError, false)
                && checkEmpty(shippingFeeError, false)
                && checkEmpty(shippingDateError, false);
            }
            return checkEmpty(totalPriceError, false)
                && checkEmpty(customerNameError, false)
                && checkEmpty(customerAddressError, false)
                && checkEmpty(customerPhonenumberError, false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(totalPriceError, true))
                message += totalPriceError + "\n";
            if (checkEmpty(customerNameError, true))
                message += customerNameError + "\n";
            if (checkEmpty(customerAddressError, true))
                message += customerAddressError + "\n";
            if (checkEmpty(customerPhonenumberError, true))
                message += customerPhonenumberError + "\n";
            if (checkEmpty(shippingFeeError, true))
                message += shippingFeeError + "\n";
            if (checkEmpty(shippingDateError, true))
                message += shippingDateError;
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
