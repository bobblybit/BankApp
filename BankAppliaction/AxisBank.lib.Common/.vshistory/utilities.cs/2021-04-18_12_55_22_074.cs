using System;
using System.Text.RegularExpressions;

namespace AxisBank.lib.Common
{
    public class utilities
    {
        /// <summary>
        /// this method checks if credentials are empty
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passowrd"></param>
        /// <returns></returns>
        public static string checkEmpty(string email, string passowrd)
        {
            if (!String.IsNullOrEmpty(email))
            {
                if (!String.IsNullOrEmpty(passowrd))
                {
                    bool validation = validateEmail(email);
                    if (validation)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "The Email is Invalid Please ";
                    }
                }
                else
                {
                    return "The Password Field Is Empty Check And Try Again";
                }
            }
            else
            {
                return "The Email Field Is Empty Check And Try Again";
            }
        }

        public static bool validateEmail(string email, string password)
        {
            string emailPattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex reg = new Regex(emailPattern);
            if (reg.IsMatch(email))
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
