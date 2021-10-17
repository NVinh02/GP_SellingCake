using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> GetCakeList(bool status);

        IEnumerable<Cake> SearchCake(string IDValue, string NameValue, bool status);

        Cake GetCakeByID(int cakeID);

        void AddNewCake(Cake cake);

        void InactivateCake(int cakeID);

        void ActivateCake(int cakeID);

        void UpdateCake(Cake cake);
    }
}
