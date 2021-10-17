using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        User CheckLogin(string username, string password);
    }
}
