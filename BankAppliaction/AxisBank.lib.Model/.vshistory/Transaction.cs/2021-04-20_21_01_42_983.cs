using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Model
{
    public class Transactions
    {
        Random generator = new Random();
        public string transactionID { get; set; }
        public string sender { get; set; }
        public string beneficairy { get; set; }
        public string amount { get; set; }
        public string typeOfTransaction { get; set; }
        public string dateOffTransaction { get; set; }
        public string remark { get; set; }


        public Transactions(string xender, string reciever, string amountoftransaction, string type, string remarks)
        {
            transactionID = "TSN-" + generator.Next(1, 400000).ToString();
            beneficairy = reciever;
            sender = xender;
            amount = amountoftransaction;
            typeOfTransaction = type;
            remark = remarks;
            dateOffTransaction = DateTime.Now.ToString("dd-MM-yyyy");
        }

    }
}
