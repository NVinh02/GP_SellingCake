using BusinessObject.Object;
using BusinessObject.ErrorsObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserValidationRepository
    {
        public string checkUserName(string username);
        public string checkUserPassword(string password);
        public string checkUserFullName(string fullname);
        public string checkUserPhoneNumber(string phonenumber);
        public string checkRedundantWhiteSpace(string obj);
        public string checkUserAddress(string address);
        public string checkUserEmail(string email);
        public UserErrors checkUser(User user, bool checkDuplicateUserName);

    }
}
