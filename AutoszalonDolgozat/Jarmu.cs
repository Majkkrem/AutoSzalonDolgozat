using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonDolgozat
{
    internal class Jarmu
    {

        public string Gyarto { get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public int Alapar { get; set; }
        public int KilometeroraAllas { get; set; }

        public Jarmu(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas)
        {
            Gyarto = gyarto;
            Modell = modell;
            Evjarat = evjarat;
            Alapar = alapar;
            KilometeroraAllas = kilometeroraAllas;
        }

        public void JarmuInfo()
        {
            Console.WriteLine($"Az auto gyártója: {Gyarto}, modellje: {Modell}, évjárata: {Evjarat} és alap ára: {Alapar}");
        }

        public void ArKalkulacio()
        {
            int thisyear = DateTime.Now.Year;
            int age = thisyear - Evjarat;
            int price = age - 15000;
            Console.WriteLine(Evjarat - price);


        }
        


        public void KmAllasFrissites(int km)
        {
            KilometeroraAllas += km;

            Console.WriteLine($"Kilóméteróra állása: {KilometeroraAllas}");
        }
    }
}
