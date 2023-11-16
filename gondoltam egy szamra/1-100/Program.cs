using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int gondoltSzam = random.Next(1, 101);
            int tipp;
            int probalkozasok = 0;



            Console.WriteLine("Gondoltam egy számra 1 és 100 között. Próbálja meg kitalálni!");



            do
            {
                Console.Write("Adjon meg egy tippet: ");

                if (int.TryParse(Console.ReadLine(), out tipp))

                {

                    probalkozasok++;



                    if (tipp < gondoltSzam)

                    {
                        Console.WriteLine("Túl kicsi!");

                    }

                    else if (tipp > gondoltSzam)

                    {
                        Console.WriteLine("Túl nagy!");

                    }

                    else
                    {
                        Console.WriteLine($"Gratulálok! Kitaláltad a számot ({gondoltSzam}) {probalkozasok} próbálkozás után!");
                    }

                }
                else
                {

                    Console.WriteLine("Hibás bemenet. Kérem, adjon meg egy érvényes számot.");
                }



            } while (tipp != gondoltSzam);
        }
    }

}

