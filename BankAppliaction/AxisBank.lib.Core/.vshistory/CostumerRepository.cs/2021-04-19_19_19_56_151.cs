using System;
using System.Collections.Generic;
using System.Text;
using AxisBank.lib.Model;

namespace AxisBank.lib.Core
{
    public static class CostumerRepository
    {
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
    }
}
