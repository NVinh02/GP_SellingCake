using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class UserDAO
    {
        //Using Singleton Pattern
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                }
                return instance;
            }
        }
        public IEnumerable<User> GetUserList()
        {
            IEnumerable<User> users = null;
            try
            {
                using var context = new CakeManagementContext();
                users = context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public User GetUserByID(int userId)
        {
            User user = null;
            try
            {
                using var context = new CakeManagementContext();
                user = context.Users.SingleOrDefault(temp => temp.Userid == userId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public User Login(string username, string password)
        {
            User user = null;
            try
            {
                using var context = new CakeManagementContext();
                user = context.Users.SingleOrDefault(temp
                    => temp.Username.Equals(username) && temp.Password.Equals(password));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public void AddUser(User user)
        {
            try
            {
                User _user = GetUserByID(user.Userid);
                if (_user == null)
                {
                    using var context = new CakeManagementContext();
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User is exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                User _user = GetUserByID(user.Userid);
                if (_user != null)
                {
                    using var context = new CakeManagementContext();
                    context.Users.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<User> SearchUserByStatus(string status)
        {
            var users = new List<User>();
            try
            {
                users = new List<User>();
                using var context = new CakeManagementContext();
                if (status.Equals("All"))
                {
                    users = context.Users.ToList();
                }
                else
                {
                    bool temp = status.Equals("True");
                    foreach (User user in context.Users.ToList())
                    {
                        if (user.Status == temp)
                        {
                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public IEnumerable<User> SearchUserByFullName(string fullname)
        {
            var users = new List<User>();
            try
            {
                users = new List<User>();
                if (!String.IsNullOrEmpty(fullname))
                {
                    using var context = new CakeManagementContext();
                    foreach (User user in context.Users.ToList())
                    {
                        if (user.Fullname.ToLower().Trim().Contains(fullname.ToLower().Trim()))
                        {
                            users.Add(user);
                        }
                    }
                } else
                {
                    throw new Exception("full name is empty");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public IEnumerable<User> SearchUserByUserName(string username)
        {
            var users = new List<User>();
            try
            {
                users = new List<User>();
                if (!String.IsNullOrEmpty(username))
                {
                    using var context = new CakeManagementContext();
                    foreach (User user in context.Users.ToList())
                    {
                        if (user.Username.ToLower().Trim().Contains(username.ToLower().Trim()))
                        {
                            users.Add(user);
                        }
                    }
                }
                else
                {
                    throw new Exception("user name is empty");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public IEnumerable<User> SearchUserByFullNameAndUserName(string fullname, string username)
        {
            var users = new List<User>();
            try
            {

                if (!String.IsNullOrEmpty(fullname) || !String.IsNullOrEmpty(username))
                {
                    using var context = new CakeManagementContext();
                    foreach (User user in context.Users.ToList())
                    {
                        if (user.Fullname.ToLower().Trim().Contains(fullname.ToLower().Trim()) 
                            && user.Username.ToLower().Trim().Contains(username.ToLower().Trim()))
                        {
                            users.Add(user);
                        }
                    }
                }
                else
                {
                    throw new Exception("full name or username are empty");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

    }
}
