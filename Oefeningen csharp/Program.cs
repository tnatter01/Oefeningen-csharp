using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double dblEur, dblUSD;

            //Bedrag in euro's opvragen
            Console.Write("Geef bedrag in euro's: ");
            dblEur = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            dblUSD = dblEur * 1.2231;

            //Het resultaat weergeven in de console
            Console.WriteLine(dblEur.ToString() + " EUR is gelijk aan " + dblUSD.ToString() + " USD.");
            Console.ReadLine();
        }
    }
}