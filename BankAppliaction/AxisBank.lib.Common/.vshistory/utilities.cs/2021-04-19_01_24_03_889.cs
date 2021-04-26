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

        /// <summary>
        /// this method removes digit from a string. it was used to validate names
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string removeDigits(string str)
        {
            string output = Regex.Replace(str, @"[\d]", string.Empty);
            return str;
        }

    }
}
