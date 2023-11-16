using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asztali_hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a tömb méretét: ");


            int n = Convert.ToInt32(Console.ReadLine());



            int[] tomb = new int[n];



         
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Adja meg a(z) {i + 1}. számot: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.Write("Adjon meg egy egész számot: ");


            int keresettSzam = Convert.ToInt32(Console.ReadLine());



            int szamlalo = 0;



          
            for (int i = 0; i < n; i++)
            {

                if (tomb[i] == keresettSzam)
                {


                    szamlalo++;
                }
            }



            Console.WriteLine($"{keresettSzam} ennyiszer szerepel a tömbben: {szamlalo} alkalommal.");

        }
    }
}
    