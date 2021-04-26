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
            string openeingBalance = "0";
            string closinBalance = initamount;
            string path = file.transactionPath;
            string type = "initial deposit";
            string remark = "Account Opening";
            List<string> data = new List<string>();
            Transactions initdeposit = new Transactions ( costid, sender, reciever, initamount, type, remark);

            data.Add(initdeposit.costumerId+","+sender+","+reciever+","+initamount+","+type+","+remark)


            return true;
        }
    }
}
