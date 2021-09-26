using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_from
{
    public class User_admin
    {
        public User user;
        public User_admin()
        {
            user = new User() { ID = 1, UserName = "admin", PassWord = "admin", Remember = true };
        }
    }
}
