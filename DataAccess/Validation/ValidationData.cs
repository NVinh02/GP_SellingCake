using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace DataAccess.Validation
{
    public class ValidationData
    {
        //Constant error
        private GeneralErrors generalErrors = new GeneralErrors();
        //User - Add/ Update
        public IList<ValidationResult> checkValidUser(User user)
        {
            IList<ValidationResult> errors = new List<ValidationResult>();
            try
            {
                ValidationContext context = new ValidationContext(user, null, null);
                if (!Validator.TryValidateObject(user, context, errors, true))
                {
                    return errors;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return errors;
        }

        //Check String
        public string CheckStringType(string name, string checkString, bool isRequired, int? min ,int max,
            string pattern)
        {
            string BodyErrorMessage = null;
           if (isRequired)
            {
                if ((BodyErrorMessage = checkStringRequired(name,checkString, isRequired)) != null)
                {
                    return BodyErrorMessage;
                }
            }
            if ((BodyErrorMessage = checkStringLength(name,checkString,min, max)) == null)
            {
                BodyErrorMessage = checkStringPattern(name,checkString, pattern);
            }
            return BodyErrorMessage;
        }
        public string checkStringLength(string name, string checkString, int? min, int max)
        {
            string errorMessage = null;
            if (checkString.Length > max)
            {
                errorMessage = name + generalErrors.ERROR_OVER_LENGTH;
            }
            else if (checkString.Length < min && min != null)
            {
                errorMessage = name + generalErrors.ERROR_LESSTHAN_LENGTH;
            }
            return errorMessage;
        }

        public string checkStringRequired(string name, string checkString, bool isRequired)
        {
            string errorMessage = null;
            if (String.IsNullOrEmpty(checkString))
            {
                errorMessage = name + generalErrors.ERROR_REQUIRED;
            }
            return errorMessage;
        }

        public string checkStringPattern(string name, string checkString, string pattern)
        {
            string errorMessage = null;
            if (Regex.IsMatch(checkString, pattern) == false)
            {
                errorMessage = name + generalErrors.ERROR_PATTERN;
            }
            return errorMessage;
        }

        //Check phone number
        public void CheckPhoneNumber(string phonenumber, int length, out bool result)
        {
            try
            {
                int number = Int32.Parse(phonenumber);
                result = number > 0 && phonenumber.Length == length;
            }
            catch (NotFiniteNumberException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
