using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatBotKlaseje
{
    class Program
    {
        static void Main(string[] args)
        {
            string atsakymas;
            Botas Pasnekesys = new Botas();
            
            while(true)
            {
            atsakymas = Console.ReadLine();
            Console.WriteLine(Pasnekesys.Atsakyk(atsakymas));
            }
            
        }
    }
}
