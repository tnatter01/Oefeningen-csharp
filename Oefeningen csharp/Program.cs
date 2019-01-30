using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double dblCelsius, dblFahrenheit;

            //Graden in Celsius opvragen
            Console.Write("Geef graden in Celsius: ");
            dblCelsius = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            dblFahrenheit = (9.00/5.00) * dblCelsius + 32.00;

            //Het resultaat weergeven in de console
            Console.WriteLine("Een temperatuur van " + dblCelsius.ToString() + " graden Celsius komt overeen met " + dblFahrenheit.ToString() + " graden Fahrenheit.");
            Console.ReadLine();
        }
    }
}