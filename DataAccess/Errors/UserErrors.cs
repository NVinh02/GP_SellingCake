using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess.Errors
{
    public class UserErrors
    {
        public string usernameError { get; set; }
        public string fullnameError { get; set; }
        public string emailError { get; set; }
        public string passwordError { get; set; }
        public string phonenumberError { get; set; }
        public string addressError { get; set; }

        public bool isEmpty()
        {
            return checkEmpty(usernameError,false) 
                && checkEmpty(fullnameError, false)
                && checkEmpty(emailError, false) 
                && checkEmpty(passwordError, false)
                && checkEmpty(phonenumberError, false)
                && checkEmpty(addressError,false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(usernameError, true))
                message += usernameError + "\n";
            if (checkEmpty(fullnameError, true))
                message += fullnameError + "\n";
            if (checkEmpty(emailError, true))
                message += emailError + "\n";
            if (checkEmpty(passwordError, true))
                message += passwordError + "\n";
            if (checkEmpty(phonenumberError, true))
                message += phonenumberError + "\n";
            if (checkEmpty(addressError, true))
                message += addressError;
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
