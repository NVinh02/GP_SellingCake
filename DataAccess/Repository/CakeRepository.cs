using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Object;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class CakeRepository : ICakeRepository
    {
        public IEnumerable<Cake> GetCakeList(bool status) => CakeDAO.Instance.GetCakeList(status);

        public IEnumerable<Cake> SearchCake(string IDValue, string NameValue, bool status) => CakeDAO.Instance.SearchCake(IDValue, NameValue, status);

        public Cake GetCakeByID(int cakeID) => CakeDAO.Instance.GetCakeByID(cakeID);

        public void AddNewCake(Cake cake) => CakeDAO.Instance.AddNew(cake);

        public void InactivateCake(int cakeID) => CakeDAO.Instance.Inactivate(cakeID);

        public void ActivateCake(int cakeID) => CakeDAO.Instance.Activate(cakeID);

        public void UpdateCake(Cake cake) => CakeDAO.Instance.Update(cake);
    }
}
