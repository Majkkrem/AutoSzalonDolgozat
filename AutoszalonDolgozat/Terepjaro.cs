using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutoszalonDolgozat
{
    internal class Terepjaro : Jarmu
    {
        public string Hajtas {  get; set; }
        public bool OffRoadKepessegek {  get; set; }

        public int Vontatokepesseg {  get; set; }
        public Terepjaro(string gyarto, string modell, int evjarat, int alapar, int kilometeroraallas, string hajtas, bool offRoadKepessegek, int vontatokepesseg) : base (gyarto,modell,evjarat,alapar, kilometeroraallas)
        {
            Hajtas = hajtas;
            OffRoadKepessegek = offRoadKepessegek;
            Vontatokepesseg = vontatokepesseg;
        }

        public void OffroadCsomagFelszerel()
        {
            Console.WriteLine("Szeretne felszerelni offroad csomagot? (i/n)");
            string valasztas = Console.ReadLine().ToLower();
            OffRoadKepessegek = false;

            if (valasztas == "i")
            {
                OffRoadKepessegek = true;
                Alapar += 60000;
            }
            else
            {
                OffRoadKepessegek = false;
            }
        }

        public void VontatokepessegBeallitasa(int kepesseg)
        {
            Vontatokepesseg = kepesseg;
            Console.WriteLine($"Vontatóképessége: {kepesseg}");
        }
    }
}
