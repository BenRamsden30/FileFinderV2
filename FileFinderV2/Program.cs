using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinderV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to this hand file searcher!");
                string[] files = FileProcess.GatherFiles();
                Console.WriteLine("Now what would you like to search for?");
                string SearchPhrase = Console.ReadLine();
                string[] foundFiles = FileSearch.SearchFiles(files, SearchPhrase);
                Console.WriteLine("Process Completed.");

                if (foundFiles.Length > 0)
                {
                    Console.WriteLine("Found files:");
                    foreach (string file in foundFiles)
                    {
                        if (file != null)
                        {
                            Console.WriteLine(file);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No Files contain that search parameter.");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
    }

