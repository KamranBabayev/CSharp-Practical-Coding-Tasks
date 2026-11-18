using System;
using System.Collections.Generic;
using System.Text;

namespace _02_UserManagement
{
    internal class User
    {
        public static int Counter { get; set; }

       
        public User()
        {
            Counter++;
        }
    }
}
