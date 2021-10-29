using BusinessObject.Object;
using BusinessObject.ErrorsObject;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserValidationRepository : IUserValidationRepository
    {
        public string checkRedundantWhiteSpace(string obj)
        => UserValidation.Instance.checkRedundantWhiteSpace(obj);

        public UserErrors checkUser(User user, bool checkDuplicateUserName)
        => UserValidation.Instance.checkUser(user, checkDuplicateUserName);

        public string checkUserAddress(string address)
        => UserValidation.Instance.checkUserAddress(address);

        public string checkUserEmail(string email)
        => UserValidation.Instance.checkUserEmail(email);

        public string checkUserFullName(string fullname)
        => UserValidation.Instance.checkUserFullName(fullname);

        public string checkUserName(string username)
        => UserValidation.Instance.checkUserName(username);

        public string checkUserPassword(string password)
        => UserValidation.Instance.checkUserPassword(password);

        public string checkUserPhoneNumber(string phonenumber)
        => UserValidation.Instance.checkUserPhoneNumber(phonenumber);
    }
}
