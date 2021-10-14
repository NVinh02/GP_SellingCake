using BusinessObject.Object;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
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

        public User Login(string email, string password)
        {
            User user = null;
            try
            {
                using var context = new CakeManagementContext();
                user = context.Users.SingleOrDefault(temp
                    => temp.Email.Equals(email) && temp.Password.Equals(password));
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
        
    }
}
