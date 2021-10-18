using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository.Interface;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implement
{
    public class CakeValidationReposiroty : ICakeValidationRepository
    {
        public CakeErrors checkCake(Cake cake)
        => CakeValidation.Instance.checkCake(cake);

        public string checkCakeAmount(int amount)
        => CakeValidation.Instance.checkCakeAmount(amount);

        public string checkCakeName(string cakename)
        => CakeValidation.Instance.checkCakeName(cakename);

        public string checkCakePrice(decimal price)
        => CakeValidation.Instance.checkCakePrice(price);

        public string checkRedundantWhiteSpace(string obj)
        => CakeValidation.Instance.checkRedundantWhiteSpace(obj);
    }
}
