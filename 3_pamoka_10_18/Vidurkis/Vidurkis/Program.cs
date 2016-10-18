using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidurkis
{
    class Program
    {

        private static decimal CalculateAverage(List<decimal> numbers)
        {
            decimal sum = 0;
            decimal average = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            average = sum / numbers.Count;

            return average;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Kiekis:");
            //string value = Console.ReadLine();
            //int n = int.Parse(value);
           
           // string[] number = new string[n];

            List<decimal> tekstas = new List<decimal>();

            while(true)
            {
                string sk = Console.ReadLine();
                if(sk == "-")
                {
                    break;
                }
                tekstas.Add(decimal.Parse(sk));
            }


            decimal average;
            //decimal[] numbers = new decimal[n];

            //Console.WriteLine("Skaiciai:");
            
                //number[i] = Console.ReadLine();
                //numbers[i] = decimal.Parse();

                average = CalculateAverage(tekstas);

            Console.WriteLine("Vidurkis:");
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
