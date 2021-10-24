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
        public User Login(string username, string password);
        public void InsertUser(User user);
        public void UpdateUser(User user);
        public IEnumerable<User> SearchUserByStatus(string status);

        public IEnumerable<User> SearchUserByFullName(string fullname);

        public IEnumerable<User> SearchUserByUserName(string username);

        public IEnumerable<User> SearchUserByFullNameAndUserName(string fullname, string username);
    }
}
