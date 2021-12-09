using System;

namespace SayilarinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi=1, toplam = 0;

            while (sayi!=0)
            {
                Console.Write("Sayı gir: ");
                sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;
            }

            Console.WriteLine("Toplam: " + toplam);
            Console.ReadKey();

        }
    }
}
