using System;

namespace Oefeningen_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, i;
            x = 0;
            y = 1;
            for (i = 0; i <= 10; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
            Console.ReadLine();
        }
    }

        }
    