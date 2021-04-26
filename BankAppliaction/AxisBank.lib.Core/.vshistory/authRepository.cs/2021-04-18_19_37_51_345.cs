using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AxisBank.lib.Model;

namespace AxisBank.lib.Core
{
    public class authRepository
    {
        /// <summary>
        /// This method registers a new user
        /// </summary>
        public static string registerUser(string email, string password)
        {
           string message = checkEmpty(email , password);
            if (message != "OK")
            {
                return message;
            }

            if (!validateEmail(email))
            {
                return message = "The E-mail is Invalid Please Use A Valid E-mail";
            }
            if (emailExist(email))
            {
                return message = "This Email has already been registered please try using another one";
            }

            return message;
        }

        /// <summary>
        /// this method validates for null login credentials
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
                    return "OK";
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

        /// <summary>
        /// this method checks if a giving input is in a email format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool validateEmail(string email)
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

        /// <summary>
        /// this method check if an email is already registered.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool emailExist(string email)
        {
            List<string> users = new List<string>();
            string path = Models.files.userLoginPath;
            users = files.readFile(path);

            foreach (var item in users)
            {
                item.Split(",");
               if (item.Contains(email))
                {
                    return true;
                }

            }
            return false;
        }

    }
}
