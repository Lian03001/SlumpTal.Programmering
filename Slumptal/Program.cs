using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slumptal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Tal = new Random();
            int SlumpTal = Tal.Next(1, 101);
            int AntalGissningar = 0;
            Console.WriteLine("Gissa på ett tal mellan 1 och 100");
            int Gissning = 0;
            while (Gissning != SlumpTal)
            {
                Gissning = int.Parse(Console.ReadLine());
                if (Gissning == SlumpTal)
                {
                    Console.WriteLine("Rätt gissat, du gissade " + AntalGissningar + " antal gångar.");
                }
                else
                {
                    AntalGissningar++;
                    Console.WriteLine("Fel gissning, försök igen.");
                }
            }

        }
    }
}
