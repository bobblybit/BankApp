using System;
using System.Collections.Generic;
using System.Text;
using AxisBank.lib.Model;

namespace AxisBank.lib.Core
{
    public class TransactionRepository
    {
        public static bool initialDeposit(string costid ,string sender, string reciever,string  initamount,string type,string  openeingBalance,string  closingBalance, string remark)
        {
            string path = file.transactionPath;

            Transactions initdeposit = new Transactions ( costid, sender, reciever, initamount, type, remark);
            return true;
        }
    }
}
