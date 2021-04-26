using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Model
{
   public class User
    {
        public  string userEmail { get; set; }
        public  string userPassword { get; set; }
        public string userId { get; set; }

        public User(string Id, string email, string password)
        {
         userId = Id;
         userEmail = email;
         userPassword = password;
        }


    }
}
