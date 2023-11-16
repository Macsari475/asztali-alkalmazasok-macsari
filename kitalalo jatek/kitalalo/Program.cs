using System;
using System.Collections.Generic;

namespace kitalalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KitalaloJatek();
        }

        static void KitalaloJatek()
        {
            List<string> szavak = new List<string>
            {
                "fuvola", "csirke", "adatok", "asztal", "fogoly", "bicska",
                "farkas", "almafa", "babona", "gerinc", "dervis", "bagoly",
                "ecetes", "angyal", "boglya"
            };

            Random random = new Random();
            string rejtettSzo = szavak[random.Next(szavak.Count)];

            string megfejtes = new string('.', rejtettSzo.Length);
            int tippekSzama = 0;

            Console.WriteLine("Kitaláló játék - találd ki a hatbetűs szót!");
            Console.WriteLine("A stop szóval bármikor leállhatsz.");

            while (megfejtes.Contains("."))
            {
                Console.WriteLine("Rejtett szó: " + megfejtes);
                Console.Write("Tipp: ");
                string tipp = Console.ReadLine().ToLower();

                if (tipp == "stop")
                {
                    Console.WriteLine("A játék leállt. A rejtett szó: " + rejtettSzo);
                    break;
                }

                if (tipp.Length != 6)
                {
                    Console.WriteLine("A tippnek hatbetűsnek kell lennie.");
                    continue;
                }

                tippekSzama++;

                for (int i = 0; i < rejtettSzo.Length; i++)
                {
                    if (rejtettSzo[i] == tipp[i])
                    {
                        char[] megfejtesArray = megfejtes.ToCharArray();
                        megfejtesArray[i] = tipp[i];
                        megfejtes = new string(megfejtesArray);
                    }
                }
            }

            if (!megfejtes.Contains("."))
            {
                Console.WriteLine("Gratulálok, megtaláltad a rejtett szót: " + rejtettSzo);
                Console.WriteLine("Tippjeid száma: " + tippekSzama);
            }
        }
    }
}













