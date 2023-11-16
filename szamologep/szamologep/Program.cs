using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez egy számológép");

            int osszeg;

            Console.Write("Elso szam:");

            int szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masodik szam:");

            int szam2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Milyen muvelet?(/,+,-,*):");

            string muvelet = Console.ReadLine();



            switch (muvelet)
            {
                case "+":
                    osszeg = szam1 + szam2;
                    Console.WriteLine("Osszeadás:" + osszeg);



                    string valasz = Console.ReadLine();
                    if (szam1 == szam2)
                    {

                    }
                    break;

                case "-":

                    osszeg = szam1 - szam2;
                    Console.WriteLine("Kivonás:" + osszeg);
                    Console.Write("Akarsz meg szamolni????(igen,nem):");
                    break;

                case "*":

                    osszeg = szam1 * szam2;
                    Console.WriteLine("Szorzás:" + osszeg);
                    Console.Write("Akarsz meg szamolni????(igen,nem):");
                    break;

                case "/":

                    osszeg = szam1 / szam2;
                    Console.WriteLine("Osztás:" + osszeg);
                    Console.Write("Akarsz meg szamolni????(igen,nem):");
                    break;

                default:

                    Console.WriteLine("Rosszat adtal meg!");
                    break;
            }
            Console.ReadKey();


           
        }
    }
}
