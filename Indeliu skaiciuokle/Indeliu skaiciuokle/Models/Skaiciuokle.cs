using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indeliu_skaiciuokle.Models
{
    public class Skaiciuokle
    {
        public int suma { get; set; }
        public int terminas { get; set; }
        public float palukanos { get; set; }
        public string indelioTipas { get; set; }
        public int papildymas { get; set; }

        public double Skaiciuoti()
        {
            if(indelioTipas == "kaupiamasis")
            {
                return SkaiciuotiSudetines();
            }
            else
            {
                return SkaiciuotiPaprastasias();
            }
        }
        public float SkaiciuotiPaprastasias()
        {
            var kiekis = suma + suma * palukanos * terminas / 100;
            return kiekis;
        }
        public double SkaiciuotiSudetines()
        {
            var kiekis = Math.Round(suma * Math.Pow(1 + palukanos / 100, terminas), 2);
            return kiekis;
        }
    }
}