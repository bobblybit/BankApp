using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Core
{
    public static class AccountRepository
    {
        static Random generator = new Random();

        public static string generateAccountNumber()
        {
         string accnum = "010"+ generator.Next(1000000, 9000000).ToString();
            return accnum;
        }
        public static bool createNewAccount(string userid ,string initamount , string acctype)
        {
            string accnum = generateAccountNumber();

            //getting costumers details
            List<string> costdata = new List<string>();

            return true;
        }
    }
}
