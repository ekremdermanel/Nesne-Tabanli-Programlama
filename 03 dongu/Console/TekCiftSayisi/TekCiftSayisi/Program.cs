using System;

namespace TekCiftSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, tekSayisi = 0, ciftSayisi = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". sayıyı giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    ciftSayisi++;
                }
                else
                {
                    tekSayisi++;
                }
            }
            Console.WriteLine("Çiftlerin sayısı: " + ciftSayisi);
            Console.WriteLine("Teklerin sayısı: " + tekSayisi);
            Console.ReadKey();
        }
    }
}
