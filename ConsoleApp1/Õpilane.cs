using System;

namespace ConsoleApp1
{
    public class Õpilane : Isik
    {
        public string Kool { get; set; } = string.Empty;
        public int Klass { get; set; }
        public double KeskmineHinne { get; set; }
        public int Puudumised { get; set; } = 0;
        public bool KasOnSotsTõend { get; set; } = false;
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis.");
        }
        public double ArvutaPalk()
        {
            double põhitoetus = 0;
            double eritoetus = 0;

            if (KeskmineHinne >= 3.8 && Puudumised <= 30)
            {
                põhitoetus += 60;
            }
            if (KasOnSotsTõend)
            {
                eritoetus += 120;
            }
            return põhitoetus + eritoetus;
        }
    }
}