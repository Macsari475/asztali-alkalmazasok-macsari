using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matekorai
{
    internal class Program
    {
        static void Main(string[] args)
        {


             int elso = 4;
             int dif = 5;
             int n = 2;
             int n_tag = 0;

            Console.WriteLine("ez a feladat kiszamolja a szamtani sorozatot");
            
            while(n_tag<=1000)
            {
                n_tag = elso + (n - 1) + dif;
                Console.Write("{0}" + ",",n_tag);
                n++;
            }

            Console.ReadKey();  

            






        }
    }
}
