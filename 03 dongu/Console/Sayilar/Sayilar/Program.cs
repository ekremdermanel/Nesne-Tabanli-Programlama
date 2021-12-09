using System;

namespace Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-10 ARASI SAYILAR");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " "); 
            }

            Console.WriteLine("\n\n1-10 ARASI TEK SAYILAR");
            for (int i = 1; i <= 10; i=i+2)
            {
                Console.Write(i + " ");   
            }

            Console.WriteLine("\n\n1-10 ARASI ÇİFT SAYILAR");
            for (int i = 2; i <= 10; i = i + 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n10-1 ARASI SAYILAR");
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n10-1 ARASI TEK SAYILAR");
            for (int i = 9; i >= 1; i=i-2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n10-1 ARASI ÇİFT SAYILAR");
            for (int i = 10; i >= 1; i = i - 2)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
