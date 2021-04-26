using System;
using System.Collections.Generic;
using System.Text;
namespace AxisBank.lib.Model
{
    public class Accounts
    {
        // declaring private fields
        public string accountID { get; set; }
        public string costumerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string accountType { get; set; }
        public string accountNumber { get; set; }
        public DateTime dateOfOpening { get; set; }

        public Accounts(string accID, string costId, string fName, string lName,string accountnum, string type)
        {
            accountID = accID;
            costumerId = costId;
            firstName =  fName;
            lastName = lName;
            accountNumber = accountnum;
            accountType = type;
            dateOfOpening = DateTime.Now;
        }


    }
}
