using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaf_2023_11_08_dobokocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dobasokSzama = 0;
            Random random = new Random();

            Console.WriteLine("Ez a program bekéri, hogy hány dobásból álljon a játék, majd ez alapján véletlenszerűen 1 és 6 között generál számokat, majd ezeket elmenti egy tömbe, majd megmondja, hogy hányszor nyert az adott illető.");
            Console.WriteLine("\nHány alkalommal legyen dobás?");
            dobasokSzama = Convert.ToInt32(Console.ReadLine());




            for (int i = 0; i < dobasokSzama; i++)
            {
                int dobas1 = random.Next(1, 7);
                int dobas2 = random.Next(1, 7);
                int dobas3 = random.Next(1, 7);

                int dobasokOsszege = dobas1 + dobas2 + dobas3;
                string nyertes = "";

                if(dobasokOsszege < 10)
                {
                    nyertes = "Anni";
                }
                else if(dobasokOsszege > 10)
                {
                    nyertes = "Panni";
                }

                Console.WriteLine("Dobás: {0} + {1} + {2} = {3} Nyert: {4}", dobas1, dobas2, dobas3, dobasokOsszege, nyertes);

            }


            Console.ReadLine();
        }
    }
}