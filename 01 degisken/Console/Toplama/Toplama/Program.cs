using System;

namespace Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            Console.Write("1. sayıyı gir:");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı gir:");
            sayi2 = int.Parse(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.ReadKey();
        }
    }
}
