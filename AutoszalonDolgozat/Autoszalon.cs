using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonDolgozat
{
    internal class Autoszalon
    {
        public List<Jarmu> Jarmuvek { get; set; }

        public Autoszalon()
        {

            Jarmuvek = new List<Jarmu>();
        }
        public void UjJarmuHozzadasa(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
        }

       

        public bool JarmuEladasa(string gyarto, string modell)
        {
            var jarmu = Jarmuvek.Find(j=>j.Gyarto == gyarto && j.Modell == modell);

            if (jarmu != null)
            {
                Jarmuvek.Remove(jarmu);

                Console.WriteLine("Sikeres eladás!");
                return true;
            }
            else
            {
                Console.WriteLine("A keresett jármú nem található!");
                return false;
            }
        }

        public Jarmu JarmuKeresese(string gyarto, string modell)
        {
            var jarmu = Jarmuvek.Find(j => j.Gyarto == gyarto && j.Modell == modell);

            if (jarmu != null)
            {
                Console.WriteLine("A keresett jármú megtalálva: " + jarmu);
                return jarmu;
            }
            else
            {
                Console.WriteLine("A keresett jármú nem található!");
                return null;
            }
        }
        


        public void JarmuvekListazasa()
        {

            foreach (var jarmu in Jarmuvek)
            {
                Console.WriteLine(jarmu);
            }
        }

        
    }


}

