using AxisBank.lib.Common;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AxisBank.lib.Model;
using System.Linq;

namespace AxisBank.lib.Core
{
    public class authRepository
    {
        /// <summary>
        /// This method registers a new user
        /// </summary>
        public static string registerUser(string email, string password)
        {

            string ID = "";

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

            ID = utilities.generateUserid();
            string path = file.userLoginPath;

            List<string> data = new List<string>();
            User user = new User(ID , email, password);
            data.Add(user.userId + "," + user.userEmail + "," + user.userPassword);
            files.writeTofile(path , data);

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
            string path = Model.file.userLoginPath;
            users = files.readFile(path);
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

        /// <summary>
        /// the method adds a new bank costumer
        /// </summary>
        /// <param name="costumerDits"></param>
        /// <returns></returns>
        public static string  addNewCostumer(List<string> costumerDits)
        {
            //removing digits from fist name and changing to title case
            costumerDits[0] = utilities.removeDigits(costumerDits[0]);
            costumerDits[0] = utilities.changeToTitle(costumerDits[0]);

            //removing digits form second name and changing to title case
            costumerDits[1] = utilities.removeDigits(costumerDits[1]);
            costumerDits[1] = utilities.changeToTitle(costumerDits[1]);

            //generating costumer id
            string ID = utilities.generateCostumerID();

            //adding costumer id to list
            costumerDits.Add(ID);

            //getting the email of last added costumer
            List<string> data = new List<string>();
            string path = file.userLoginPath;
            data = files.readFile(path);
            string line = data[data.Count - 1];
            string email = line.Split(",")[1];

            //instance of costumer
            Costumers costumer = new Costumers(ID, costumerDits[0], costumerDits[1], email, costumerDits[2], costumerDits[3]);
            data.Clear();

            //setting and saving costumers details
            path = file.costumerPath;
            data.Add(costumer.costumerId + "," + costumer.firstName + "," + costumer.lastName + "," + costumer.e_mail + "," + costumer.phoneNumber +","+costumer.cust_Address);

            if (files.writeTofile(path, data))
            {
                return ID;
            }
            return "ERROR:";

        }

    }
}
