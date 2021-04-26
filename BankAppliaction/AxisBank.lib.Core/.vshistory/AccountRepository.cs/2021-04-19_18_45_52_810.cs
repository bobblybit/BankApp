using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Core
{
    public class AccountRepository
    {
        Random generator = new Random();
        public string generateAccountNumber()
        {
            string accnum = "010"+ generator.Next(1000000, 9000000).ToString();
            return "OK";
        }
        public static bool createNewAccount(string userid ,string initamount , string acctype)
        {


            return true;
        }
    }
}
