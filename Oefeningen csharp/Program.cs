using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            int intAantalSchoenen;
            double dblPrijs;
            const double cdblPrijs = 100.00;

            //Opvragen aantal schoenen
            Console.Write("Hoeveel schoenen wil je kopen: ");
            intAantalSchoenen = Convert.ToInt16(Console.ReadLine());

            //Het resultaat weergeven in de console
            Console.WriteLine();
            if(intAantalSchoenen >= 2)
            {
                dblPrijs = ((cdblPrijs * intAantalSchoenen) / 100 * 75);
                Console.Write("Prijs: €" + Math.Round(dblPrijs, 2).ToString());
            }
            else
            {
                dblPrijs = (cdblPrijs * intAantalSchoenen);
                Console.Write("Prijs: €" + Math.Round(dblPrijs, 2).ToString());
            }
            Console.ReadLine();
        }
    }
}