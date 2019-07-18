using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchEngineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Form1 gui = new Form1(); INCOMPLETE GUI
            //gui.ShowDialog(); INCOMPLETE GUI 
            string wordRx = @"\w+";
            Search search = new Search();
            search.initialize(); //ADJUST NUMBER OF PAGES TO PROCESS IN THE DATA CLASS, IVE SET IT TO 80000, <1MIN OF PROCESSING
            string term = "o";
            while (term != "")
            {
                Console.Write("Ask sham: ");
                term = Console.ReadLine();
                Match match = Regex.Match(term, wordRx, RegexOptions.IgnoreCase);
                List<string> searchTerms = new List<string>();
                while (match.Success)
                {
                    searchTerms.Add(match.Value);
                    match = match.NextMatch();
                }
                search.multiWord(searchTerms);
            }

            Console.ReadKey();
        }
    }
}
