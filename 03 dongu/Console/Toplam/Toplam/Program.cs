using System;

namespace Toplam
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int toplam=0;
            double ortalama;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sayı gir:");
                sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;
            }

            ortalama = (double) toplam / 5;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Ortalama: " + ortalama);
            Console.ReadKey();
        }
    }
}
