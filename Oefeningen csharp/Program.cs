using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kleuren instellen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Declaratie van de variabelen
            int intGetal1, intGetal2, intSom;

            //De 2 getallen opvragen
            Console.Write("Geef getal1: ");
            intGetal1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geef getal2: ");
            intGetal2 = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            intSom = intGetal1 + intGetal2;

            //Kleuren instellen
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;

            //Het resultaat weergeven in de console
            Console.WriteLine("De som bedraagt " + intSom.ToString());
            Console.ReadLine();
        }
    }
}
