using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return String.IsNullOrEmpty(usernameError) && String.IsNullOrEmpty(fullnameError)
                && String.IsNullOrEmpty(emailError) && String.IsNullOrEmpty(passwordError)
                && String.IsNullOrEmpty(phonenumberError) && String.IsNullOrEmpty(addressError);
        }
    }
}
