using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Isik
    {
        // Privaatne väli - otse ligi ei saa
        private int sünniaasta;

        public string Nimi { get; set; }

        public void NimiKüsi ()
        {
            Console.WriteLine("Sisesta sinu nimi:");
            Nimi = Console.ReadLine();
        }

        public void Tervita()
        {
            Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana.");
        }

        // Kontrollitud omadus
        public int Sünniaasta
        {
            get { return sünniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sünniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
            }
        }

        // Arvutatud omadus (ainult lugemiseks / getter)
        public int Vanus => DateTime.Now.Year - sünniaasta;
    }
}