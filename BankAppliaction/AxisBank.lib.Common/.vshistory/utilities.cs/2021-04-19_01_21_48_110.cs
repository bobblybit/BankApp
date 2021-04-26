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

        /// <summary>
        /// this method generates costumer ID
        /// </summary>
        /// <returns></returns>
        public static string generateCostumerID()
        {
            string ID = "cax" + generator.Next(100, 500);
            return ID;
        }

        public static string removeDigits(string name)
        {

            return name;
        }

    }
}
