using System;
using System.Collections.Generic;
using System.Text;

namespace AxisBank.Logic.Model
{
    class Logs
    {
        public DateTime logindate { get; set; }
        public string email { get; set; }
        public Logs(string email)
        {
            logindate = DateTime.Now;
        }

    }
}
