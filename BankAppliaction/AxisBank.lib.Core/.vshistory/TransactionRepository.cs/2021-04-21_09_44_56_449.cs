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
            string openeingBalance = "0";
            string closinBalance = initamount;
            string path = file.transactionPath;
            string type = "initial deposit";
            string remark = "Account Opening";
            List<string> data = new List<string>();
            Transactions initdeposit = new Transactions ( costid, sender, reciever, initamount, type, remark);

            //writing to transaction file
            data.Add(initdeposit.transactionID+","+ "," + sender + "," + reciever + "," + initamount + "," + type +","+ openeingBalance+ ","+ closinBalance +","+ remark);
            FileRepository.writeTofile(path, data);


            return true;
        }

        public static bool depositToAccount(string benaccNumber, decimal amount)
        {
            string typeofTransaction = "deposit";

            //Transactions newdeposit = new Transactions();
            return true;
        }
    }
}
