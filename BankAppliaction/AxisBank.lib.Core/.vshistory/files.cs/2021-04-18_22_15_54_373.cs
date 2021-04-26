using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AxisBank.lib.Models;

namespace AxisBank.lib.Core
{
    class files
    {
        /// <summary>
        /// this method reads any file in the dataStore and returns the file data in a list
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string> readFile(string path)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            return lines;
        }

        public static bool writeToUserData(string ID, string email, string password, string path)
        {

            return true;
        }

    }
}
