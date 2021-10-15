using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Validation
{
    public class UserValidation
    {
        
        public static IList<ValidationResult> checkLogin(string username, string password, out bool result)
        {
            IList<ValidationResult> e = new List<ValidationResult>();
            try
            {
                var user = new User
                {
                    Username = username,
                    Password = password,
                };

                ValidationContext context = new ValidationContext(user, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(user, context, errors, true))
                {
                    e = errors;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }
    }
}
