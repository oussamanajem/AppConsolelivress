using ConsoleAppConsolelivress;
using System;

namespace AppConsoleLivres
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Revue revue1 = new Revue("Boreal study", "OussamaNajem", 40, 101, 2022);
            Revue revue2 = new Revue("Boreal lib", "OussamaNajem", 50, 102, 2023);
            Revue revue3 = new Revue("Boreal IT", "OussamaNajem", 45, 103, 2024);

            revue1.AfficherDetails();
            revue2.AfficherDetails();
            revue3.AfficherDetails();
        }
    }
}

