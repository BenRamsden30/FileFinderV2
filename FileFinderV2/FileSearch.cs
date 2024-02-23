using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinderV2
{
    internal class FileSearch
    {
        #region Searching through files in location
        public static string[] SearchFiles(string[] files, string phrase)
        {
            string[] returnFiles = new string[files.Length];
            int counter = 0;
            foreach (string file in files)
            {
                bool present = FileChecker(file, phrase);
                if (present)
                {
                    returnFiles[counter] = Path.GetFileName(file);
                    counter++;
                }
            }
            return returnFiles;
        }
        #endregion

        #region File Interogation
        public static bool FileChecker(string file, string phrase)
        {
            string[] data = File.ReadAllLines(file);

            foreach (string line in data)
            {
                bool has = line.Contains(phrase);
                if (has)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
