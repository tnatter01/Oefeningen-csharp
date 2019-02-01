using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double dblAantalRatten, dblJaren, dblGroeiPercentage;
            dblAantalRatten = 2000000;
            dblJaren = 0;
            dblGroeiPercentage = 1.15;

            while (dblAantalRatten < 10000000)
            {
                dblAantalRatten = dblAantalRatten * dblGroeiPercentage;
                dblJaren++;
            } 

            Console.Write("Na " + dblJaren.ToString() + " jaren zijn er 10.000.000 ratten in New York.");
            Console.ReadLine();
        }
    }
}