using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
        public User Login(string Email, string password);
        public void InsertUser(User user);
        public void UpdateUser(User user);
    }
}
