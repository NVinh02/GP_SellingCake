using BusinessObject.Object;
using DataAccess.Errors;
using System.Text.RegularExpressions;

namespace DataAccess.Validation
{
    public class UserValidation
    {
        #region Note
        //Format for cmt on each function 
        //1st cmt: Specify what ur validation code is used for which class (total of five: Cake, Employee, Order, Order Detail, with Common being a universal function
        //2nd cmt: Briefly explain what the function does, if the name of the function name is alreay self explainatory just type it here
        //3rd cmt: Further elaborate on what the function does (if needed)
        //4th cmt: Give a specification on what does ur function checking (the range, reg ex, ...)
        //also, everything that is hard code in this project won't be checked in this validation class
        #endregion

        #region Initialized Objects
        private ValidationData validation = null;
        private static UserValidation instance = null;
        private static readonly object instanceLock = new object();
        private UserValidation() { }
        public static UserValidation Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserValidation();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Common
        //Check if the text field is redundant whitespace
        public string checkRedundantWhiteSpace(string obj)
        {
            Regex trimmer = new Regex(@"\\s\\s+");
            return obj = trimmer.Replace(obj.Trim(), " ");
        }
        #endregion

        #region User

        /*--------------------------------------------------------------------------------*/
        //For User
        //Checking User's Username
        //Including checking both the length and regex as well
        //Specification: No special character and whitespace, from 1 to 50 characters

        public string checkUserName(string username)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("username", username, true, 1, 50, @"^[a-zA-Z0-9]{1,50}$");
            return error;
        }

        public string checkUserNameDuplicated(string username)
        {
            validation = new ValidationData();
            string error = validation.checkDuplicatedUserName(username);
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For User
        //Checking User's Password
        //Including checking both the length and regex as well
        //Specification: No whitespace, from 1 to 30 characters

        public string checkUserPassword(string password)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("password", password, true, 1, 30, @"^[^\s]+$");
            return error;
        }
        /*--------------------------------------------------------------------------------*/
        //For User
        //Checking User's Fullname
        //Including checking both the length and regex as well
        //Specification: No special character and number, from 1 to 100 characters

        public string checkUserFullName(string fullname)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("full name", fullname, true, 1, 30, @"^[a-zA-Z\s]{1,50}$");
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For User
        //Checking User's Phone Number
        //Including checking both the length and regex as well
        //Specification: Only number, exactly 10 characrers
        public string checkUserPhoneNumber(string phonenumber)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("phone number", phonenumber, true, 1, 10, @"^[0-9]{10}$");
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For User
        //Checking User's Address
        //Including checking both the length and regex as well
        //Specification: Address can only contain alphabet characters, number, whitespace and this "/" special character, from 1 to 50 characters
        //For Member Overall
        public string checkUserAddress(string address)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("address", address, true, 1, 50, @"^[A-Za-z0-9/\s]*$");
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For User
        //Checking User's Email
        //Including checking both the length and regex as well
        //Specification: Follow this format abc@xyz.t(.v) with anything in () is optional

        public string checkUserEmail(string email)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("email", email, true, null, 50, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            return error;
        }
        
        //Check User
        public UserErrors checkUser(User user, bool checkDuplicateUserName)
        {
            UserErrors userErrors = null;
            userErrors = new UserErrors();
            if (checkDuplicateUserName)
            {
                if ((userErrors.usernameError = checkUserNameDuplicated(user.Username)) == null)
                    userErrors.usernameError = checkUserName(user.Username);
            } else
                userErrors.usernameError = checkUserName(user.Username);
            userErrors.fullnameError = checkUserFullName(user.Fullname);
            userErrors.emailError = checkUserEmail(user.Email);
            userErrors.passwordError = checkUserPassword(user.Password);
            userErrors.phonenumberError = checkUserPhoneNumber(user.Phonenumber);
            userErrors.addressError = checkUserAddress(user.Address);

            if (userErrors.isEmpty())
                userErrors = null;
            return userErrors;
        }

        #endregion user
    }
}
