using System;
using System.Text;
using System.Text.RegularExpressions;
namespace AxisBank.lib.Core
{
    public class authRepository
    {
        /// <summary>
        /// This method validates if a giving entry is an email
        /// </summary>

        public static bool validatePattern(string input)
        {
            string emailPattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex reg = new Regex(emailPattern);
            if (reg.IsMatch(input))
            {
             return (true);
            }
            else
            {
             return (false);
            }
        }




    }
}
