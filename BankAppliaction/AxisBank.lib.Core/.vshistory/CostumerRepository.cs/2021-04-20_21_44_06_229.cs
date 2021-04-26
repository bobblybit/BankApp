using System;
using System.Collections.Generic;
using System.Text;
using AxisBank.lib.Model;
using AxisBank.lib.Common;

namespace AxisBank.lib.Core
{
    public static class CostumerRepository
    {
        /// <summary>
        /// getting user id
        /// </summary>
        /// <param name="costid"></param>
        /// <returns></returns>
        public static string getCostumerDetails(string costid)
        {
            string path = file.costumerPath;
            List<string> costdata = new List<string>();
            costdata = FileRepository.readFile(path);
            string cost = "";

            foreach (var line in costdata)
            {
                if (line.Split(",")[0] == costid)
                {
                  return  cost = line;
                }

            }
            return cost;
        }

        /// <summary>
        /// the method adds a new bank costumer
        /// </summary>
        /// <param name="costumerDits"></param>
        /// <returns></returns>
        public static string addNewCostumer(List<string> costumerDits)
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
            data = FileRepository.readFile(path);
            string line = data[data.Count - 1];
            string email = line.Split(",")[1];

            //instance of costumer
            Costumers costumer = new Costumers(ID, costumerDits[0], costumerDits[1], email, costumerDits[2], costumerDits[3]);
            data.Clear();

            //setting and saving costumers details
            path = file.costumerPath;
            data.Add(costumer.costumerId + "," + costumer.firstName + "," + costumer.lastName + "," + costumer.e_mail + "," + costumer.phoneNumber + "," + costumer.cust_Address);

            if (FileRepository.writeTofile(path, data))
            {
                return ID;
            }
            return "ERROR:";

        }

        public static string getCostumerByEmail(string email)
        {
            string path = file.costumerPath;
            List<string> costdata = new List<string>();
            costdata = FileRepository.readFile(path);
            string cost = "";

            foreach (var line in costdata)
            {
                if (line.Split(",")[0] == email)
                {
                    return cost = line;
                }

            }
            return cost;

        }
    }
}
