using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Model
{
    public class Transactions
    {
        Random generator = new Random();
        public string transactionID { get; set; }
        public string costumerId { get; set; }
        public string sender { get; set; }
        public string beneficairy { get; set; }
        public decimal amount { get; set; }
        public string typeOfTransaction { get; set; }
        public decimal openingBalance { get; set; }
        public decimal closingBalance { get; set; }
        public string dateOffTransaction { get; set; }
        public string remark { get; set; }


        public Transactions(string custID, string xender, string reciever, decimal amountoftrans, string type, string remarks)
        {
            costumerId = custID;
            beneficairy = reciever;
            sender = xender;
            amount = amountoftrans;
            typeOfTransaction = type;
            remark = remarks;
            transactionID = "TSN-" + generator.Next(1, 400000).ToString();
            dateOffTransaction = DateTime.Now.ToString("dd-MM-yyyy");
        }

    }
}
