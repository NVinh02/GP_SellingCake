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

        public User Login(string username, string password)
        => UserDAO.Instance.Login(username, password);

        public void UpdateUser(User user)
        => UserDAO.Instance.UpdateUser(user);

        IEnumerable<User> IUserRepository.SearchUserByFullName(string fullname)
        => UserDAO.Instance.SearchUserByFullName(fullname);

        IEnumerable<User> IUserRepository.SearchUserByFullNameAndUserName(string fullname, string username)
        => UserDAO.Instance.SearchUserByFullNameAndUserName(fullname, username);

        IEnumerable<User> IUserRepository.SearchUserByStatus(string status)
        => UserDAO.Instance.SearchUserByStatus(status);

        IEnumerable<User> IUserRepository.SearchUserByUserName(string username)
        => UserDAO.Instance.SearchUserByUserName(username);
    }
}
