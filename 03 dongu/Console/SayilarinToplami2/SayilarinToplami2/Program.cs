using System;

namespace SayilarinToplami2
{
    class Program
    {

        // Girilen sayıların toplamı 100ü geçinceye kadar toplam alan
        // 100ü geçtiğinde kaç sayı girildiğini ekranda gösteren prg
        static void Main(string[] args)
        {
            int sayi, toplam = 0, adet = 0;

            while (toplam < 100)
            {
                Console.Write("Sayı gir: ");
                sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;
                adet++;
                Console.WriteLine("Toplam: " + toplam);
            }

            
            Console.WriteLine("Girilen sayı: " + adet);
            Console.ReadKey();
        }
    }
}
