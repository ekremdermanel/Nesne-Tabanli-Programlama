using System;

namespace DortIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, toplam, fark, carpim, bolum;
            Console.Write("1. sayıyı gir:");
            sayi1 = double.Parse(Console.ReadLine());
            Console.Write("2. sayıyı gir:");
            sayi2 = double.Parse(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların toplamı: " + toplam);

            fark = sayi1 - sayi2;
            Console.WriteLine("Sayıların farkı: " + fark);

            carpim = sayi1 * sayi2;
            Console.WriteLine("Sayıların çarpımı: " + carpim);

            bolum = sayi1 / sayi2;
            Console.WriteLine("Sayıların bölümü: " + bolum);

            Console.ReadKey();
        }
    }
}
