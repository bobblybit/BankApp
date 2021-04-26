using AxisBank.lib.Common;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AxisBank.lib.Model;
using System.Linq;

namespace AxisBank.lib.Core
{
    public class AuthRepository
    {
        public static string  loginIn(string email , string password)
        {
            string message = checkEmpty(email, password);
            if (message != "OK")
            {
                return message;
            }
            if (!validateEmail(email))
            {
                return "The E-mail is Invalid Please Use A Valid E-mail";
            }
             if (authLoginCredentails(email , password))
             {
                return "correct";
            }
            else
            {
                return "Incorrect login details";
            }
                //next


            return message="Email does not exist";
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
            string path = Model.file.userLoginPath;
            users = FileRepository.readFile(path);
            string emailtest;

            foreach (var line in users)
            {
                emailtest = line.Split(",")[1];
                if (emailtest == email)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool authLoginCredentails(string email , string password)
        {
            //removing data from the file
            string path = file.userLoginPath;
            List<string> data = new List<string>();
            data = FileRepository.readFile(path);


            //checking for password in data
            foreach (var item in data)
            {
                if (item.Split(",")[1] == email)
                {
                    string testpass = item.Split(",")[2];
                    if (testpass == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }
           return false;
        }

    }
}
