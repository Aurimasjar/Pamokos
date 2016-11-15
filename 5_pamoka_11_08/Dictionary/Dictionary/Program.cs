using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileTextLines = File.ReadLines(@"D:\SAUGYKLA\Aurimas 4G\Pamokos\5_pamoka_11_08\Dictionary\Dictionary\chatBot.txt").ToList();
            string[] splitLine;
            Dictionary<string, string> dictionary = //new Dictionary<string, string>();
            fileTextLines.ToDictionary(item => item.Split('~')[0].Trim(), item => item.Split('~')[1].Trim());

            /*foreach (var item in fileTextLines)
            {
                splitLine = item.Split('~');
                dictionary.Add(splitLine[0].Trim(), splitLine[1].Trim());
            }*/
            while(true)
            {
                string input = Console.ReadLine();
                if(dictionary.ContainsKey(input))
                {
                    Console.WriteLine(dictionary[input]);
                }
                if(string.Compare(input, "Quit", true) == 0)
                {
                    break;
                }
                if(!dictionary.ContainsKey(input))
                {
                    Console.WriteLine("Sorry, I don't have any answer :(");
                }
            }
        }
    }
}
