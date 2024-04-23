using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonDolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autoszalon autoszalon = new Autoszalon();
            Szemelyauto szemelyauto = new Szemelyauto("Toyota", "Corolla", 2021, 8000000, 15000, 5, 6.5, "Fehér");
            Terepjaro terepjaro = new Terepjaro("Land Rover", "Defender", 2020, 15000000, 20000, "4WD", true, 3500);


            autoszalon.UjJarmuHozzadasa(szemelyauto);
            autoszalon.UjJarmuHozzadasa(terepjaro);


            bool eladasSikeres = autoszalon.JarmuEladasa("Toyota", "Corolla");
            if (eladasSikeres)
            {
                Console.WriteLine("A tranzakció sikeres volt, és a jármű törlésre került a készletből.");
            }
            else
            {
                Console.WriteLine("A tranzakció sikertelen volt, vagy a jármű nem található a készletben.");
            }

            autoszalon.JarmuKeresese("Land Rover", "Defender");


           
            Console.WriteLine("Az autószalonban elérhető járművek:");
            autoszalon.JarmuvekListazasa();


           

            


            Console.ReadLine();
        }
        
    }
}
