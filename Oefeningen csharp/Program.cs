using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double dblEclBTW, dblInclBTW;

            //Bedrag in euro's opvragen
            Console.Write("Geef bedrag in euro's: ");
            dblEclBTW = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            dblInclBTW = dblEclBTW * 1.21;

            //Het resultaat weergeven in de console
            Console.WriteLine("De prijs incl. BTW bedraagt " + dblInclBTW.ToString() + ".");
            Console.ReadLine();
        }
    }
}