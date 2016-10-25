using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"D:\SAUGYKLA\Aurimas 4G\Pamokos\4_pamoka_10_25\FileIO\FileIO\longestNameInput.txt"); // nuskaityk failą į input kintamąjį

            FindSportsmenWithLongestFullname(input);
            FindSportsmenWithLongestFullnameLikeAPro(input);

            SortSportsmenByFullnameLength(input);
        }

        public static void FindSportsmenWithLongestFullname(string input)
        {
            //sukarpyk input į string[]

            string[] namesArray = input.Split(',');

            //surask ilgiausią vardą

            int didi = 0;
            int did = 0;
            for (int i = 0; i < namesArray.Length; i++)
            {
                if(namesArray[i].Length > did)
                {
                    didi = i;
                    did = namesArray[i].Length;
                }
            }

            //išvesk į failą longestNameV1.txt

            for (int i = 0; i < namesArray.Length; i++)
            {
                if(didi == i)
                {
                    File.WriteAllText(@"D:\SAUGYKLA\Aurimas 4G\Pamokos\4_pamoka_10_25\FileIO\FileIO\longestNameV1.txt", namesArray[i]);
                }
            }

        }

        public static void FindSportsmenWithLongestFullnameLikeAPro(string input)
        {
            //sukarpyk input į List<string>

            List<string> names = input.Split(',').Select(name => name.Trim()).ToList();

            //surask ilgiausią vardą

            List<string> orderedList = names.OrderByDescending(name => name.Length).ToList();
            string ilg = orderedList.First();

            //išvesk į failą longestNameV2.txt

            File.WriteAllText(@"D:\SAUGYKLA\Aurimas 4G\Pamokos\4_pamoka_10_25\FileIO\FileIO\longestNameV2.txt", ilg);
        }
        
        public static void SortSportsmenByFullnameLength(string input)
        {
            //sukarpyk input į List<string>

            string[] namesArray = input.Split(',');
            List<string> names = namesArray.ToList();

            //surūšiuok pagal vardo ilgį

            List<string> orderedList = names.OrderBy(name => name.Length).ToList();

            //išvesk į failą sortedNames.txt

             File.WriteAllLines(@"D:\SAUGYKLA\Aurimas 4G\Pamokos\4_pamoka_10_25\FileIO\FileIO\sortedNames.txt", orderedList.Cast<string>());
        }
    }
}
