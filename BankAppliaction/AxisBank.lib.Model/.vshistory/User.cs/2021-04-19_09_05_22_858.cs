using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.Logic.Model
{
   public class User
    {
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string custId { get; set; }

        public User(string cust_Id, string email, string password)
        {
         custId = cust_Id;
         userEmail = email;
         userPassword = password;
        }


    }
}
