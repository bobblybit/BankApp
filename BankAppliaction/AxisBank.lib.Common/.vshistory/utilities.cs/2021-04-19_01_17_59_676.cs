using System;
using System.Text.RegularExpressions;

namespace AxisBank.lib.Common
{
    public static class utilities
    {
        static Random generator = new Random();

        /// <summary>
        /// this method generate userID
        /// </summary>
        /// <returns></returns>
        public static string generateUserid()
        {
            string ID = "axu" + generator.Next(100, 500);
            return ID;
        }

        public static string generateCostumerID()
        {
            string ID = "axc" + generator.Next(100, 500);
            return ID;
        }

    }
}
