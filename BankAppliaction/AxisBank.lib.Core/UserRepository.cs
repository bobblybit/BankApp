using System;
using System.Collections.Generic;
using System.Text;
using AxisBank.lib.Model;


namespace AxisBank.lib.Core
{
    public class UserRepository
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
        /// This method registers a new user
        /// </summary>
        public static string registerUser(string email, string password)
        {


            string ID = "";
            string message =AuthRepository.checkEmpty(email, password);
            if (message != "OK")
            {
                return message;
            }

            if (!AuthRepository.validateEmail(email))
            {
                return message = "The E-mail is Invalid Please Use A Valid E-mail";
            }
            if (AuthRepository.emailExist(email))
            {
                return message = "This Email has already been registered please try using another one";
            }

            ID = generateUserid();
            string path = file.userLoginPath;

            List<string> data = new List<string>();
            User user = new User(ID, email, password);
            data.Add(user.userId + "," + user.userEmail + "," + user.userPassword);
            FileRepository.writeTofile(path, data);

            return message;

        }
    }
}
