using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chatBotKlaseje
{
    public class Botas
    {
        private List<string> fileTextLines;
        private Dictionary<string, string> dictionary;
        static string dejaNe = "Neturiu atsakymo :(";

        public Botas()
        {
            fileTextLines = File.ReadLines(@"D:\SAUGYKLA\Aurimas 4G\Pamokos\6_pamoka_11_15\chatBotKlaseje\chatBot.txt").ToList();
            dictionary = fileTextLines.ToDictionary(item => item.Split('~')[0].Trim(), item => item.Split('~')[1].Trim());
        }

        public string Atsakyk(string sakinys)
        {
            if (dictionary.ContainsKey(sakinys))
            {
                return dictionary[sakinys];
            }
            else
                return dejaNe;
           
                /*if(string.Compare(sakinys,"Quit", true) == 0)
                {
                    break;
                }
                if(!dictionary.ContainsKey(sakinys))
                {
                    Console.WriteLine("Sorry, I don't have any answer :(");
                }*/
           
        }
    }
}
