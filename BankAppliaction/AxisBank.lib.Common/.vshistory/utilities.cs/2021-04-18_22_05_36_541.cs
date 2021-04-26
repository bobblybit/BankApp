using System;
using System.Text.RegularExpressions;

namespace AxisBank.lib.Common
{
    public static class utilities
    {
        static Random generator = new Random();
        public static string generateUserid()
        {
            string ID = "AXU-" + generator.Next(100, 500);
            return ID;
        }

    }
}
