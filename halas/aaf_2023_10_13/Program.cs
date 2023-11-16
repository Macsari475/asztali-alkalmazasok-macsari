using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaf_2023_10_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a program bekéri 14 hal hosszát és súlyát és kiírja a halak összsúlyát és az átlagos hosszúságot, a 70dkg-nál nagyobb halakat összegét, illetve a 50dkg-nál nagyobb és 28 cm-nél hosszabb halak összegét, van-e 2kg-nál nagyobb hal, van-e a kifogott halak között 40dkg alatti, Legkissebb súlyú halnak a mérete, illetve a súlyát a legnagyobb méretű halnak.\n");
            double[] halHossz = new double[2];
            double[] halSuly = new double[2];
            double osszSuly = 0;
            double osszHossz = 0;
            int i = 0;
            int hal70DkgSuly = 0;
            int hal50Dkgés28 = 0;
            bool nagyhal = false;
            bool kishal = false;

            for (i = 0; i < halHossz.Length; i++)
            {
                Console.WriteLine("Add meg az {0}. hal hosszát. Kérlek cm-ben add meg.", i + 1);
                halHossz[i] = Convert.ToDouble(Console.ReadLine());
                osszHossz = osszHossz + halHossz[i];

                Console.WriteLine("Add meg az {0}. hal súlyát. Kérlek kg-ban add meg.", i + 1);
                halSuly[i] = Convert.ToDouble(Console.ReadLine());
                osszSuly = osszSuly + halSuly[i];

                if (halSuly[i] > 0.7)
                {
                    hal70DkgSuly++;
                }

                if (halSuly[i] > 0.5 && halHossz[i] > 28)
                {
                    hal50Dkgés28++;
                }

                if (halSuly[i] > 2)
                {
                    nagyhal = true;
                }

                if (halSuly[i] < 0.4)
                {
                    kishal = true;
                }

            }

            Console.WriteLine("Halak összsúlya: {0} kg.", osszSuly);
            Console.WriteLine("A halak átlagos hossza: {0} cm.", osszHossz / i);
            Console.WriteLine("A halak 70dkg-nál nagyobbak: {0} db.", hal70DkgSuly);
            Console.WriteLine("A halak 50dkg-nál nagyobbak és 28 cm-nél hosszabbak: {0} db.", hal50Dkgés28);
            Console.WriteLine("A kifogott halak között van-e 2 kg-nál nagyobb hal: {0}.", nagyhal);
            Console.WriteLine("A kifogott halak között van-e 40 dkg-nál kissebb hal: {0}.", kishal);
            int MinHal = Array.IndexOf(halSuly, halSuly.Min());
            Console.WriteLine("Legkissebb súlyú halnak a mérete: {0} cm.", halHossz[MinHal]);
            int MaxHal = Array.IndexOf(halHossz, halHossz.Max());
            Console.WriteLine("Legnagyobb méretű halnak a súlya: {0} cm.", halSuly[MaxHal]);
            Console.ReadLine();
        }
    }
}