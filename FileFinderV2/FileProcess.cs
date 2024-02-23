using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinderV2
{
    internal class FileProcess
    {
        #region This gathers all the files in the target location
        public static string[] GatherFiles()
        {
            Console.WriteLine("Please Select a file location.");
            //string path = SelectDirectory(ConfigurationSettings.AppSettings["Location"]);

            string[] files = Directory.GetFiles(ConfigurationSettings.AppSettings["Location"]);
            return files;
        }
        #endregion

        #region Allows directory selection - TBC
        public static void SelectDirectory()
        {
            //TBD
        }
        #endregion
    }
}
