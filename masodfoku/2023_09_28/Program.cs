using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az egyenlet egyutthatojat!");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adja meg az elsofoku egyutthatojat!");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adja meg a tiszta tag erteket!");
            double c = Convert.ToDouble(Console.ReadLine());

            double Disztkriminans = b * b - 4 * a * c;
            Console.WriteLine("A diszkriminans erteke {0}", Disztkriminans);

            if (Disztkriminans < 0)
            {
                Console.WriteLine("Az egyenletnek nincs valós gyöke!");
            }
            else
            {
                double Megoldas_1 = ((-1) * b + Math.Sqrt(Disztkriminans)) / (2 * a);
                double Megoldas_2 = ((-1) * b + Math.Sqrt(Disztkriminans)) / (2 * a);
                Console.WriteLine("Az első megoldás: x1={0:0.00} \nA második megoldás: x2={1:0.00}", Megoldas_1);
            }

            Console.ReadLine();
        }
    }
}
