using System;

namespace ConsoleApp1
{
    public abstract class Isik
    {
        private int sünniaasta;

        public string Nimi { get; set; } = string.Empty;

        public int Sünniaasta
        {
            get => sünniaasta;
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sünniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
            }
        }

        public int Vanus => sünniaasta == 0 ? 0 : DateTime.Now.Year - sünniaasta;

        public void Tervita()
        {
            if (!string.IsNullOrWhiteSpace(Nimi) && sünniaasta != 0)
            {
                Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana. Olen sündinud {Sünniaasta} aastal.");
            }
            else
            {
                Console.WriteLine("Vale andmed");
            }
        }

        public abstract void Kirjelda();
    }
}