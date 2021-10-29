﻿using BusinessObject.Object;
using BusinessObject.ErrorsObject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
namespace DataAccess.Validation
{
    public class ValidationData
    {
        //Constant error
        private GeneralErrors generalErrors = new GeneralErrors();

        #region String
        public string CheckStringType(string name, string checkString, bool isRequired, int? min ,int max,
            string pattern)
        {
            string BodyErrorMessage = null;
           if (isRequired)
            {
                if ((BodyErrorMessage = checkStringRequired(name,checkString)) != null)
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
            else if (checkString.Length < min && min is not null)
            {
                errorMessage = name + generalErrors.ERROR_LESSTHAN_LENGTH;
            }
            return errorMessage;
        }

        public string checkStringRequired(string name, string checkString)
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

        public string checkDuplicatedUserName(string username)
        {
            string errorMessage = null;
            UserDAO dao = new UserDAO();
            if (dao.DuplicatedUsername(username) is not null)
                errorMessage = username + generalErrors.DUPLICATED_NAME;
            return errorMessage;
        }
        #endregion

        #region Number
        public string CheckNumber(string name ,string checkNumber, int? min, int max,
            bool isRequired, bool isInterger)
        {
            string BodyErrorMessage = null;
            if (isRequired)
            {
                if ((BodyErrorMessage = checkStringRequired(name, checkNumber)) != null)
                {
                    return BodyErrorMessage;
                }
            }

            BodyErrorMessage = isInterger == true ? checkIntegerNumber(name, checkNumber)
                :checkDecimalNumber(name, checkNumber);
            if (BodyErrorMessage is null || min is not null | max != null)
            {
                BodyErrorMessage = isInterger == true ? checkIntegerNumberBoundary(name, checkNumber, min, max)
                : checkDecimalNumberBoundary(name, checkNumber, min, max);
            }
            return BodyErrorMessage;
        }

        private string checkIntegerNumber(string name, string checkNumber)
        {
            string errorMessage = null;
            try
            {
                int number = Int32.Parse(checkNumber);
                if (number < 0)
                {
                    return errorMessage = name + generalErrors.ERROR_NEGATIVE_NUMBER;
                }
            }
            catch (Exception ex)
            {
                errorMessage = name + generalErrors.NUMBERFORMATEXCEPTION;
            }

            return errorMessage;
        }

        private string checkDecimalNumber(string name, string checkNumber)
        {
            string errorMessage = null;
            try
            {
                decimal number = decimal.Parse(checkNumber);
                if (number < 0)
                    return errorMessage = name + generalErrors.ERROR_NEGATIVE_NUMBER;
            }
            catch (Exception ex)
            {
                errorMessage = name + generalErrors.NUMBERFORMATEXCEPTION;
            }

            return errorMessage;
        }

        private string checkIntegerNumberBoundary(string name, string checkNumber,int? min, int max)
        {
            string errorMessage = null;
            int number = Int32.Parse(checkNumber);
            if (min != null)
            {
                return errorMessage = number < min ? name + generalErrors.ERROR_NEGATIVE_NUMBER : null;
            }
            errorMessage = number > max ? name + generalErrors.ERROR_NEGATIVE_NUMBER : null;

            return errorMessage;
        }

        private string checkDecimalNumberBoundary(string name, string checkNumber, int? min, int max)
        {
            string errorMessage = null;
            decimal number = decimal.Parse(checkNumber);
            if (min != null)
            {
                return errorMessage = number < (decimal)min ? name + generalErrors.ERROR_NEGATIVE_NUMBER : null;
            }
            errorMessage = number > (decimal)max ? name + generalErrors.ERROR_NEGATIVE_NUMBER : null;

            return errorMessage;
        }
        #endregion

        #region Date

        //For Order 
        //Check Date: Shipping Date
        //Check if Date entered is of valid format (yyyy - MM - dd) and is not null
        //Specification: compare string date against format
        public string checkValidDate(string name, string checkDate)
        {
            string errorMessage = null;
            //DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dt;
            string format = "yyyy-MM-dd";
            if (DateTime.TryParseExact(checkDate, format,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out dt) == false)
            {
                errorMessage = name + generalErrors.ERROR_DATEFORMAT;
            }
            return errorMessage;
        }

        public string checkDate(string name, string checkDate, bool isRequired)
        {
            string BodyErrorMessage = null;
            if (isRequired)
            {
                if ((BodyErrorMessage = checkStringRequired(name, checkDate)) != null)
                    return BodyErrorMessage;
            }
            BodyErrorMessage = checkValidDate(name, checkDate);
            return BodyErrorMessage;
        }

        #endregion
    }
}