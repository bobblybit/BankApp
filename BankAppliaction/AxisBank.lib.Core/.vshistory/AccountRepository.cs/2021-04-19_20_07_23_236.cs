using System;
using System.Collections.Generic;
using System.Text;
using AxisBank.lib.Model;

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
        public static bool createNewAccount(string costid ,string initamount , string acctype)
        {
            string accnum = generateAccountNumber();

            //getting costumers details
            string costdata = "";
            string AccName = "";

            costdata = CostumerRepository.getCostumerDetails(costid);
            string firstName = costdata.Split(",")[1];
            string lastName = costdata.Split(",")[2];
            AccName = firstName + " " + lastName;



            return true;
        }
    }
}
