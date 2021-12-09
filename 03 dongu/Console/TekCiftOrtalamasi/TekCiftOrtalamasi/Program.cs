using System;

namespace TekCiftOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet, sayi, tekSayisi = 0, ciftSayisi = 0, tekToplami = 0, ciftToplami = 0;

            Console.Write("Kaç sayı girmek istiyorsunuz?");
            adet = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= adet; i++)
            {
                Console.Write(i + ". sayıyı giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    ciftToplami = ciftToplami + sayi;
                    ciftSayisi++;
                }
                else
                {
                    tekToplami = tekToplami + sayi;
                    tekSayisi++;
                }
            }
            Console.WriteLine("Çiftlerin ortalaması: " + (ciftToplami / ciftSayisi));
            Console.WriteLine("Teklerin ortalaması: " + (tekToplami / tekSayisi));
            Console.ReadKey();
        }
    }
}
