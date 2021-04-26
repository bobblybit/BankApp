using System;
using System.Collections.Generic;
using System.Text;
using AxisBank.lib.Model;

namespace AxisBank.lib.Core
{
    public static class AccountRepository
    {
        static Random generator = new Random();

        /// <summary>
        /// this method generates a a new account number
        /// </summary>
        /// <returns></returns>
        public static string generateAccountNumber()
        {
         string accnum = "010"+ generator.Next(1000000, 9000000).ToString();
            return accnum;
        }

        /// <summary>
        /// generate acount id
        /// </summary>
        /// <returns></returns>
        public static string generateAccountID()
        {
            string accID = "AXC" + generator.Next(100, 900).ToString();
            return accID;
        }

        /// <summary>
        /// this method creates a new bank account
        /// </summary>
        /// <param name="costid"></param>
        /// <param name="initamount"></param>
        /// <param name="acctype"></param>
        /// <returns></returns>
        public static bool createNewAccount(string costid ,string initamount , string acctype)
        {
            //generating IDS
            string accnum = generateAccountNumber();
            string accID = generateAccountID();

            //getting costumers details
            string costdata = "";
            costdata = CostumerRepository.getCostumerDetails(costid);
            string firstName = costdata.Split(",")[1];
            string lastName = costdata.Split(",")[2];

            //creating a new instance of account
            Accounts newAccount = new Accounts(accID, costid, firstName, lastName, accnum, acctype);

            //setting data to write to file
            List<string> data = new List<string>();
            data.Add (newAccount.accountID+","+costid+","+newAccount.firstName+","+newAccount.lastName+","+accnum+","+acctype+","+newAccount.dateOfOpening +","+ initamount);
            string path = file.accountPath;
            FileRepository.writeTofile(path, data);

            //registering the transaction
            string sender = firstName + " " + lastName;
            string reciever = sender;
            TransactionRepository.initialDeposit(costid ,sender, reciever, initamount);
            return true;
        }

        /// <summary>
        /// the method makes deposits
        /// </summary>
        public static List<string> confirmAccount(string accnum)
        {
            List<string> data = new List<string>();
            List<string> retdata = new List<string>();
            string path = file.accountPath;
            data = FileRepository.readFile(path);


            foreach (var item in data)
            {
                if (item.Split(",")[4] == accnum)
                {
                    retdata.Add(item.Split(",")[4]);
                    retdata.Add(item.Split(",")[5]);
                    return retdata;
                }

            }


            return data;
        }
    }
}
