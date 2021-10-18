using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Text.RegularExpressions;

namespace DataAccess.Validation
{
    public class CakeValidation
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
        private CakeErrors cakeErrors = null;
        private static CakeValidation instance = null;
        private static readonly object instanceLock = new object();
        private CakeValidation() { }
        public static CakeValidation Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CakeValidation();
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

        #region Cake

        //For Cake
        //Checking Cake Name
        //Including checking both the length and regex as well
        //Specification: No special character and number, from 1 to 100 characters
        public string checkCakeName(string cakename)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("Cake Name", cakename, true, 1, 100, @"^[a-zA-Z\s]{1,100}$");
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Cake
        //Checking Cake Price
        //Since it's already int --> no regex need to be check
        //Specification: the number has to be in the range of 1 to 10 000 000
       public string checkCakePrice(decimal price)
        {
            validation = new ValidationData();
            string checkNumber = Convert.ToString(price);
            string error = validation.CheckNumber("Price", checkNumber, 1, 10000000,true,false);
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Cake
        //Checking Cake Ammount
        //Since it's already int --> no regex need to be check
        //Specification: the number has to be in the range of 1 to 1 000
        public string checkCakeAmount(int amount)
        {
            validation = new ValidationData();
            string checkNumber = Convert.ToString(amount);
            string error = validation.CheckNumber("Amount", checkNumber, 1, 1000, true, true);
            return error;
        }


        //Cake
        public CakeErrors checkCake(Cake cake)
        {
            CakeErrors cakeErrors = new CakeErrors();
            cakeErrors.cakeNameError = checkCakeName(cake.Cakename);
            cakeErrors.priceError = checkCakePrice(cake.Price);
            cakeErrors.amountError = checkCakeAmount(cake.Amount);
            if (cakeErrors.isEmpty())
                cakeErrors = null;
            return cakeErrors;
        }
        #endregion
    }
}
