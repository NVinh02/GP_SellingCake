using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsEnable { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
