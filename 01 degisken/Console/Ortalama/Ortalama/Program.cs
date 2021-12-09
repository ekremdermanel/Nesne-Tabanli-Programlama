using System;

namespace Ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            int puan1, puan2;
            double ortalama;
            Console.Write("1. notu gir: ");
            puan1 = int.Parse(Console.ReadLine());
            Console.Write("2. notu gir: ");
            puan2 = int.Parse(Console.ReadLine());
            ortalama = (double) (puan1 + puan2) / 2;
            Console.WriteLine("Ortalama: " + ortalama);

            if (ortalama >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }


            Console.ReadKey();
        }
    }
}
