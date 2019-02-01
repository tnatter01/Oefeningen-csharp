using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            int intLeeftijd;

            //Opvragen hoeken A en C
            Console.Write("Wat is je leeftijd: ");
            intLeeftijd = Convert.ToInt16(Console.ReadLine());

            //Het resultaat weergeven in de console
            Console.WriteLine();
            if(intLeeftijd >= 18)
            {
                Console.WriteLine("Je bent " + intLeeftijd + " jaar oud. Je mag deelnemen aan de spelen van de Nationale Loterij.");
            }
            else
            {
                Console.WriteLine("Om deel te nemen aan de spelen van de Nationale Loterij moet je minimum 18 jaar oud zijn.");
            }
            Console.ReadLine();
        }
    }
}