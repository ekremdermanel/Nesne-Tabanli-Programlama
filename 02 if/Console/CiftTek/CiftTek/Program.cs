using System;

namespace CiftTek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Sayı gir:");
            sayi = int.Parse(Console.ReadLine());

            if (sayi%2==0)
            {
                Console.WriteLine("Çift");
            }
            else
            {
                Console.WriteLine("Tek");
            }
            Console.ReadKey();
        }
    }
}
