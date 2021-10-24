using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.ErrorsObject
{
    public class CakeErrors
    {
        public string cakeNameError { get; set; }
        public string priceError { get; set; }
        public string amountError { get; set; }

        public bool isEmpty()
        {
            return checkEmpty(cakeNameError, false)
                && checkEmpty(priceError, false)
                && checkEmpty(amountError, false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(cakeNameError, true))
                message += cakeNameError + "\n";
            if (checkEmpty(priceError, true))
                message += priceError + "\n";
            if (checkEmpty(amountError, true))
                message += amountError + "\n";
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
