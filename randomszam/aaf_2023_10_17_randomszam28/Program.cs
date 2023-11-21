using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaf_2023_10_17_randomszam28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int hetszam = 0;
            double negativAtlag = 0;
            int nullaInt = 0;
            int pozitivSzamok = 0;
            int negativSzamok = 0;
            bool pozSzamok = false;
            bool negSzamok = false;
            Console.WriteLine("Ez a program generál random számokat -10 és 10 között egy 28 elemű tömbben, majd a beprogramozott feltételrendszer alapján kiírja, hogy miből, illetve hogyan mennyi van.");
            int[] tomb = new int[28];
            int i = 0;

            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-10, 11);

                Console.Write(", {0}", tomb[i]);

                if (tomb[i] < 0)
                {
                    negativSzamok++;
                }
                else if (tomb[i] > 0) 
                { 
                    pozitivSzamok++;
                }

                if (negativSzamok > pozitivSzamok)
                {
                    negSzamok = true;
                }
                else if(negativSzamok < pozitivSzamok)
                {
                    pozSzamok = true;
                }

                if (tomb[i] == 7)
                {
                    hetszam++;
                }

                if (tomb[i] == 0)
                {
                    nullaInt = i;
                }

                if (tomb[i] < 0)
                {
                    negativAtlag = negativAtlag + tomb[i];
                }

            }


            int legkissebPoz = int.MaxValue;
            int legnagyobbNeg = int.MinValue;

            foreach (int szam in tomb)
            {
                if (szam > 0 && szam < legkissebPoz)
                {
                    legkissebPoz = szam;
                }
                else if(szam < 0 && szam > legnagyobbNeg)
                {
                    legnagyobbNeg = szam;
                }
            }

            Console.WriteLine("\nA rész:");
            Console.WriteLine("\nNegatív számból van-e több: {0}", negSzamok);
            Console.WriteLine("\nPozitív számból van-e több: {0}", pozSzamok);

            Console.WriteLine("B rész:");
            Console.WriteLine("\nEnnyiszer fordult elő a 7 szám: {0}", hetszam);

            Console.WriteLine("C rész");
            Console.WriteLine("\n Ebben az elemű tömbben volt 0 az érték: {0}", nullaInt + 1);

            Console.WriteLine("D rész:");
            Console.WriteLine("\nNegítív számok átlaga: {0}", Math.Round(negativAtlag / i, 2));

            Console.WriteLine("E rész:");
            Console.WriteLine("\n Legkissebb pozitív szám: {0}", legkissebPoz);

            Console.WriteLine("F rész:");
            Console.WriteLine("\n Legnagyobb negatív szám: {0}", legnagyobbNeg);

            Console.ReadLine();
        }
    }
}