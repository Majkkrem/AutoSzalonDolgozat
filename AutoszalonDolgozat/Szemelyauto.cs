using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonDolgozat
{
    internal class Szemelyauto : Jarmu
    {

        public int UlesekSzama {  get; set; }
        public double Fogyasztas {  get; set; }

        public string Szin {  get; set; }
        public Szemelyauto(string gyarto, string modell, int evjarat, int alapar, int kilometeroraallas, int ulesekSzama, double fogyasztas, string szin) : base( gyarto, modell,  evjarat, alapar, kilometeroraallas)
        {
            UlesekSzama = ulesekSzama;
            Fogyasztas = fogyasztas;
            Szin = szin;
        }

        public void KenyelmiExtraBeszerzese(string extra)
        {
            Console.WriteLine("Milyen extra funkciót szeretne az autóba? (Klíma, Sportülés, Sötétített ablak");

            extra = Console.ReadLine().ToLower();

            if (extra == "Klíma")
            {
                Alapar += 25000;
            }
            else if (extra == "Sportülés")
            {
                Alapar += 40000;
            }
            else if (extra == "Sötétített ablak")
            {
                Alapar += 30000;
            }
            else
            {
                Console.WriteLine("Kérem adjon meg egy extrát a felsoroltak közül.");
            }

           
        }
        public void SzinFrissitese(string ujSzin) 
        {
            Szin = ujSzin;
            Console.WriteLine($"Színe: {ujSzin}");
        }

    }
}
