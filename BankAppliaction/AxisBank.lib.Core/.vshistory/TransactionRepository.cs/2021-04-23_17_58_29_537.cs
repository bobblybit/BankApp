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


        public static string withdrawal(string reciever,string  amount, string  remark)
        {
            string balance = "";
            return balance;
        }




    }
}
