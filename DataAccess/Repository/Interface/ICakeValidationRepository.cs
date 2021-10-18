using BusinessObject.Object;
using DataAccess.Errors;

namespace DataAccess.Repository.Interface
{
    public interface ICakeValidationRepository
    {
        public string checkRedundantWhiteSpace(string obj);
        public string checkCakeName(string cakename);
        public string checkCakePrice(decimal price);
        public string checkCakeAmount(int amount);
        public CakeErrors checkCake(Cake cake);

    }
}
