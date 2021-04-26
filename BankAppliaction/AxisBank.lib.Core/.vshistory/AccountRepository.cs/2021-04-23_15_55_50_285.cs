﻿using System;
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
            string accnum = "010" + generator.Next(1000000, 9000000).ToString();
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
        public static bool createNewAccount(string costid, string initamount, string acctype)
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
            data.Add(newAccount.accountID + "," + costid + "," + newAccount.firstName + "," + newAccount.lastName + "," + accnum + "," + acctype + "," + newAccount.dateOfOpening + "," + initamount);
            string path = file.accountPath;
            FileRepository.writeTofile(path, data);

            //registering the transaction
            string remark = "initial deposit";
            TransactionRepository.DepositToAccount (accnum, initamount, remark);
            return true;
        }

        /// <summary>
        /// the method makes deposits
        /// </summary>
        public static string confirmAccount(string accnum)
        {
            List<string> data = new List<string>();
            string retdata = "";
            string path = file.accountPath;
            data = FileRepository.readFile(path);


            foreach (var item in data)
            {
                if (item.Split(",")[4] == accnum)
                {
                    retdata = item.Split(",")[2] + " " + item.Split(",")[3] + " " + item.Split(",")[4];
                    return retdata;
                }

            }
            return retdata;
        }

        /// <summary>
        /// this method get all the account of a user by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static List<string > getAccountById(string id)
        {
            string path = file.accountPath;
            List<string> costaccdata = new List<string>();
            costaccdata = FileRepository.readFile(path);
            List<string> accdits = new List<string>(); ;

            foreach (var line in costaccdata)
            {
                if (line.Split(",")[1] == id)
                {
                    if (line.Split(",")[5] == "Saving Account")
                    {
                        accdits.Add(line);
                    }
                    if (line.Split(",")[5] == "Current Account")
                    {
                        accdits.Add(line);
                    }
                }

            }
            return accdits;
        }

        /// <summary>
        /// this method checks user account balance
        /// </summary>
        public static decimal checkBalance(string custId , string accType)
        {
            decimal balance = 0;
            string accountnumber = "";
            List<string> costAcc = new List<string>();
            List<string> transactionList = new List<string>();
            costAcc = getAccountById(custId);

            //getting specific  account number of a user
            if (accType == "Saving Account")
            {
                accountnumber = costAcc[0].Split(",")[4];
            }
            else
            {
                accountnumber = costAcc[1].Split(",")[4];
            }

            //getting all the transaction down by or on the account
            string path = file.transactionPath;
             transactionList =  FileRepository.readFile(path);

            //calculating transactions done won the account
            if (transactionList.Count==0)
            {
                balance = 0;
            }
            else
            {
                foreach (var item in transactionList)
                {
                    if (item.Split(",")[1] == accountnumber)
                    {
                        string amount = item.Split(",")[2];
                        decimal addamount = decimal.Parse(amount);
                        balance += addamount;
                    }
                }

            }


            return balance;
        }



    }
}
