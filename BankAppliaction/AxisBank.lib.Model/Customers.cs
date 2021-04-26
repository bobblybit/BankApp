using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.lib.Model
{
    public class Costumers
    {
        public string costumerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string e_mail { get; set; }
        public string phoneNumber { get; set; }
        public string cust_Address { get; set; }
        public DateTime Date { get; set; }

        public  Costumers(string costId,string fname,  string lName, string email,string phone ,string address)
        {
            costumerId = costId;
            firstName = fname;
            lastName = lName;
            e_mail = email;
            cust_Address = address;
            phoneNumber = phone;
            Date = DateTime.Now;
        }


    }
}
