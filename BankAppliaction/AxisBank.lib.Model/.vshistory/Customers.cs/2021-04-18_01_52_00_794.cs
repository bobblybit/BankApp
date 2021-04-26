using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.Logic.Model
{
    public class Costumers
    {
        public string costumerId { get; set; }
        public string nameOfCostumer { get; set; }
        public string e_mail { get; set; }
        public string cust_Address { get; set; }
        public DateTime Date { get; set; }
        public string typeOfAccount { get; set; }

        public  Costumers(string costId, string fullname, string email, string address, string type)
        {
          costumerId = costId;
          nameOfCostumer = fullname;
          e_mail = email;
          cust_Address = address;
          typeOfAccount = type;
          Date = DateTime.Now;
        }


    }
}
