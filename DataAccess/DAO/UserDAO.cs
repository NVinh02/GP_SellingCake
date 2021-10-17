using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Object;
using BusinessObject.DBContext;

namespace DataAccess.DAO
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public User checkLogin(string username, string password)
        {
            using var context = new CakeManagementContext();
            User user = context.Users.SingleOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
            return user;
        }
    }
}
