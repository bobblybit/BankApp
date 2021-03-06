using System;
using System.Text;
using AxisBank.lib.Common;
namespace AxisBank.lib.Core
{
    public class authRepository
    {
        /// <summary>
        /// This method registers a new user
        /// </summary>
        public static string registerUser(string email, string password)
        {
           string message = utilities.checkEmpty(email , password);
            if (message != "OK")
            {
                return message;
            }

            if (!utilities.validateEmail(email))
            {
                return message = "The Email is Invalid";
            }

            return message;
        }

    }
}
