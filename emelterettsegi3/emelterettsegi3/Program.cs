using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string[]> telekLista = new List<string[]>();

        try
        {
            if (File.Exists("utca.txt"))
            {
                string[] sorok = File.ReadAllLines("utca.txt");

                foreach (string sor in sorok)
                {
                    string[] adatok = sor.Split(' ');

                    if (adatok.Length >= 5)
                    {
                        telekLista.Add(adatok);
                    }
                }

                int telekSzam = telekLista.Count;
                Console.WriteLine($"2. Feladat: Az állományban {telekSzam} telek adatai vannak.");
            }
            else
            {
                Console.WriteLine("A 'utca.txt' fájl nem található.");
                return;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hiba történt az állomány olvasása közben: {ex}");
            return;
        }

        Console.Write("3. Feladat: Kérem, adja meg a tulajdonos adószámát: ");
        string adoszam = Console.ReadLine();

        bool talalat = false;

        foreach (string[] adatok in telekLista)
        {
            if (adatok.Length >= 5 && adatok[4].ToLower() == adoszam.ToLower())
            {
                Console.WriteLine($"A megadott adószámmal rendelkező tulajdonos az {adatok[0]} utcában, {adatok[1]}. házszám alatt lakik.");
                talalat = true;
                break;
            }
        }

        if (!talalat)
        {
            Console.WriteLine("Nem szerepel az adatállományban.");
        }

        Console.ReadKey();
    }
}

