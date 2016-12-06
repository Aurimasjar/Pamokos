using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntaxTest.Exercises
{
    public class Exercise11
    {
        /*
          Parašykite viešą metodą pavadinimu WhoCanDriveATractor, kuris grąžina string tipo sąrašo rezultatą. Įsidėmėkite, kad sąrašas yra aprašomas kitaip nei masyvas.
          Metodas turi priimti vieną DrivingLicence tipo masyvo elementą pavadinimu licences.
          DrivingLicence tipas yra klasė, kuri dar neegzistuoja, jūs turite ją parašyti šalia šiame faile.
        */

        public List<string> WhoCanDriveATractor(DrivingLicence[] licences)
        {
            List<string> drivers = new List<string>();
            for(int i = 0; i < licences.Length; i++)
            {
                if(licences[i].category == "C")
                {
                    drivers.Add(licences[i].name);
                }
            }
            return drivers;
        }
    }

    public class DrivingLicence
    {
        public string name;
        public string category;
    }
}
