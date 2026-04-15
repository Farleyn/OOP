using System;

namespace ConsoleApp1
{
    public class Õpetaja : Isik, ITööline
    {
        public string Aine { get; set; } = string.Empty;
        public double Tunnitasu { get; set; }
        public int TunnidKuus { get; set; }

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja õpetan ainet {Aine}.");
        }
        public double ArvutaPalk()
        {
            return Tunnitasu * TunnidKuus;
        }
    }
}