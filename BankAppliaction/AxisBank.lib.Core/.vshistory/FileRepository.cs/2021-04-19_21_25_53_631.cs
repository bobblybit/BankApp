using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AxisBank.lib.Model;

namespace AxisBank.lib.Core
{
    public class FileRepository
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

        /// <summary>
        /// this method writes to the user data file
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool writeTofile(string path, List<string>data)
        {
            File.WriteAllLines(path, data);
            return true;
        }

    }
}
