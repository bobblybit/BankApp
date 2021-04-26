using System;
using System.Collections.Generic;
using System.Text;
using AxisBank.lib.Model;

namespace AxisBank.lib.Core
{
    public class TransactionRepository
    {
        public static bool initialDeposit(string costid ,string sender, string reciever,string  initamount)

        {
            //setting up data to write to file
            string path = file.transactionPath;
            decimal depositamount = decimal.Parse(initamount);
            string type = "initial deposit";
            string remark = "Account Opening";
            List<string> data = new List<string>();
            Transactions initdeposit = new Transactions(reciever, depositamount, remark); ;

            //writing to transaction file
            data.Add(initdeposit.transactionID + "," + reciever + "," + depositamount + "," +"" + type +","+ remark);
            FileRepository.writeTofile(path, data);


            return true;
        }

        /// <summary>
        /// this method deposit money to costumer account
        /// </summary>
        /// <param name="reciever"></param>
        /// <param name="depositamount"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public static bool DepositToAccount(string reciever, string  depositamount, string remark)
        {
             decimal amount = decimal.Parse(depositamount);
            List<string> data = new List<string>();

            //setting up transaction details
            Transactions newtrans = new Transactions(reciever, amount, remark);
            data.Add(newtrans.transactionID + "," + reciever  + "," +  newtrans.amount + "," + newtrans.dateOffTransaction + "," + newtrans.remark);

            //adding a new transaction to the database
            string path = file.transactionPath;
            FileRepository.writeTofile(path, data);
            return true;
        }

        /// <summary>
        /// this method withdraws from giving account
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <param name="remark"></param>
        /// <param name="accounType"></param>
        /// <returns></returns>
        public static bool withdrawalFromAccount(string id, decimal amount, string remark, string accounType)
        {
            List<string> data = new List<string>();
            string accntnum = "";
            data = AccountRepository.getAccountById(id);
            foreach (var item in data)
            {
                if (item.Split(",")[5] == accounType)
                {
                    accntnum = item.Split(",")[4];
                    break;
                }
            }

            data.Clear();
            Transactions newtrans = new Transactions(accntnum, amount, remark);
            data.Add(newtrans.transactionID + "," + accntnum + "," + newtrans.amount + "," + newtrans.dateOffTransaction + "," + newtrans.remark);

            //adding a new transaction to the database
            string path = file.transactionPath;
            FileRepository.writeTofile(path, data);
            return true;
        }

        public static List<string> getFiveTransactions( string id)
        {
            List<string> lastestTransactions = new List<string>();
            //getting latest transactions
            string path = file.transactionPath;
            lastestTransactions = FileRepository.readFile(path);




            return lastestTransactions;
        }

        /// <summary>
        /// this method transfers money to another account
        /// </summary>
        /// <param name="senderId"></param>
        /// <param name="recieverAccount"></param>
        /// <param name="amount"></param>
        /// <param name="remark"></param>
        /// <param name="senderAccntType"></param>
        /// <returns></returns>
        public static string transferFund(string senderId, string recieverAccount, decimal amount, string remark, string senderAccntType)
        {
            //getting senders account number
            string senderaccnum = AccountRepository.getAccountByIdAndType(senderId, senderAccntType);
            string message = "";
            //setting withdrawal and deposit amount
            string amountToDeposit = amount.ToString();
            string stringamount = amount.ToString();
            stringamount += "-";
            decimal amountToWithdraw = decimal.Parse(stringamount);
            if (senderaccnum == recieverAccount)
            {
                return message = "The sender's and receiver's account are the same you cant not transfer to the same account";
            }
            else
            {
                DepositToAccount(recieverAccount, amountToDeposit, remark);
                withdrawalFromAccount(senderId, amountToWithdraw, remark, senderAccntType);
                return message = "OK";
            }
        }

        public static List<string> getAccountStatement(string id , string accType)
        {
            List<string> data = new List<string>();
            List<string> accStatement = new List<string>();
            string accnum = AccountRepository.getAccountByIdAndType(id, accType);


            if (accnum == "")
            {
                accStatement.Add($"You don't have a {accType} yet");
            }
            else
            {
                string path = file.transactionPath;
                data = FileRepository.readFile(path);
                foreach (var item in data)
                {
                    if (item.Split(",")[5] == accnum)
                    {
                        accStatement.Add(item);
                    }
                }
            }




            return accStatement;
        }
    }
}
