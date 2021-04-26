using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Model
{
    public class Transactions
    {
        Random generator = new Random();
        public string transactionID { get; set; }
        public string account { get; set; }
        public decimal amount { get; set; }
        public string dateOffTransaction { get; set; }
        public string remark { get; set; }


        public Transactions(string taccount,  decimal amountoftransaction, string remarks)
        {
            transactionID = "TSN-" + generator.Next(1, 400000).ToString();
            account = taccount;
            amount = amountoftransaction;
            remark = remarks;
            dateOffTransaction = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}
