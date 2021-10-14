using BusinessObject.Object;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetUsers()
        => UserDAO.Instance.GetUserList();

        public void InsertUser(User user)
        => UserDAO.Instance.AddUser(user);

        public User Login(string Email, string password)
        => UserDAO.Instance.Login(Email, password);

        public void UpdateUser(User user)
        => UserDAO.Instance.UpdateUser(user);
    }
}
