using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Core
{
    public class AccountRepository
    {
        Random generator = new Random();
        public  string generateAccountNumber()
        {
            string accnum = "010"+ generator.Next(1000000, 9000000).ToString();
            return accnum;
        }
        public  bool createNewAccount(string userid ,string initamount , string acctype)
        {
            string accnum = generateAccountNumber();

            return true;
        }
    }
}
