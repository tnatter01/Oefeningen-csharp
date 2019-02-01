using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double dblHoekA, dblHoekC, dblAfstandAB;
            const double cdblAfstandAC = 10;

            //Opvragen hoeken A en C
            Console.Write("De grootte van hoek A (in graden) =  ");
            dblHoekA = Convert.ToDouble(Console.ReadLine());
            Console.Write("De grootte van hoek C (in graden) =  ");
            dblHoekC = Convert.ToDouble(Console.ReadLine());

            //Afstand AB Berkenen
            dblAfstandAB = (cdblAfstandAC * Math.Sin(dblHoekC * Math.PI / 180)) / (Math.Sin((dblHoekA * Math.PI / 180) + (dblHoekC * Math.PI / 180)));

            //Het resultaat weergeven in de console
            Console.WriteLine();
            Console.WriteLine("De afstand AB = " + Math.Round(dblAfstandAB,1).ToString() + " meter.");
            Console.ReadLine();
        }
    }
}