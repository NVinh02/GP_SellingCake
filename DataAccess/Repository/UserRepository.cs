using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Object;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public User CheckLogin(string username, string password) => UserDAO.Instance.checkLogin(username, password);
    }
}
