using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.Logic.Model
{
    class Accounts
    {
        // declaring private fields
        public string costumerId { get; set; }
        public string accountName { get; set; }
        public string accountType { get; set; }
        public string accountNumber { get; set; }
        public decimal accBalance { get; set; }
        public DateTime dateOfOpening { get; set; }

        public Accounts(string costId, string accname, string accountnum, string type, decimal initdeposit)
        {
            costumerId = costId;
            accountName = accname;
            accountNumber = accountnum;
            accountType = type;
            dateOfOpening = DateTime.Now;
            accBalance = initdeposit;
        }


    }
}
