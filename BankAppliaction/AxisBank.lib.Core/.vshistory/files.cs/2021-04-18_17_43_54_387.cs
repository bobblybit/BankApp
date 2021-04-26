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
        public static List<string> readFile(string path)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            return lines;
        }

    }
}
