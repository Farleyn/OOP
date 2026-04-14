using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Isik inimene1 = new Isik();
            inimene1.NimiKüsi();
            inimene1.Sünniaasta = 2009;
            inimene1.Tervita();
            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Filipp";
            õpetaja1.Sünniaasta = 1980;
            õpetaja1.Aine = "Matemaatika";
            õpetaja1.Õpeta();
            õpetaja1.Tervita();
            Õpilane õpilane1 = new Õpilane();
            õpilane1.Kool = "Avatud Kool";
            õpilane1.Klass = 9;
        }
    }
}